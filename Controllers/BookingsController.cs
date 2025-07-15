﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternalBookingSystem.Data;
using InternalBookingSystem.Models;

namespace InternalBookingSystem.Controllers
{
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Bookings.Include(b => b.Resource);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Resource)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["ResourceId"] = new SelectList(_context.Resources.Where(r => r.IsAvailable), "Id", "Name");//cannot book a unavailable resource
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ResourceId,StartTime,EndTime,BookedBy,Purpose")] Booking booking)
        {
            //End Time must be after Start Time
            if (booking.EndTime <= booking.StartTime)
            {
                ModelState.AddModelError("EndTime", "End Time must be after Start Time.");
            }


            if (ModelState.IsValid)
            {
                // Check for overlapping bookings
                var overlappingBookings = await _context.Bookings
                    .Where(b => b.ResourceId == booking.ResourceId &&
                                ((b.StartTime < booking.EndTime && b.EndTime > booking.StartTime)))
                    .ToListAsync();

                if (overlappingBookings.Any())
                {
                    ModelState.AddModelError("", "This resource is already booked during the requested time. Please choose another slot or resource, or adjust your times.");
                    ViewData["ResourceId"] = new SelectList(_context.Resources, "Id", "Name", booking.ResourceId);
                    return View(booking);
                }

                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ResourceId"] = new SelectList(_context.Resources, "Id", "Name", booking.ResourceId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ResourceId"] = new SelectList(_context.Resources.Where(r => r.IsAvailable), "Id", "Name", booking.ResourceId);//cannot book a unavailable resource
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ResourceId,StartTime,EndTime,BookedBy,Purpose")] Booking booking)
        {
            if (id != booking.Id)
            {
                return NotFound();
            }

            if (booking.EndTime <= booking.StartTime)
            {
                ModelState.AddModelError("EndTime", "End Time must be after Start Time.");
            }

            if (ModelState.IsValid)
            {
                var overlappingBookings = await _context.Bookings
                        .Where(b => b.ResourceId == booking.ResourceId &&
                                    b.Id != booking.Id && // Exclude the current booking
                                    ((b.StartTime < booking.EndTime && b.EndTime > booking.StartTime)))
                        .ToListAsync();

                if (overlappingBookings.Any())
                {
                    ModelState.AddModelError("", "This resource is already booked during the requested time. Please choose another slot or resource, or adjust your times.");
                    ViewData["ResourceId"] = new SelectList(_context.Resources, "Id", "Name", booking.ResourceId);
                    return View(booking);
                }

                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ResourceId"] = new SelectList(_context.Resources, "Id", "Name", booking.ResourceId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Resource)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
