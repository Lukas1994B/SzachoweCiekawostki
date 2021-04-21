using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SzachoweCiekawostki.Data;
using SzachoweCiekawostki.Models;

namespace SzachoweCiekawostki
{
    public class ChessPlayersController : Controller
    {
        private readonly MvcChessPlayersContext _context;

        public ChessPlayersController(MvcChessPlayersContext context)
        {
            _context = context;
        }

        // GET: ChessPlayers
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChessPlayers.ToListAsync());
        }

        // GET: ChessPlayers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chessPlayers = await _context.ChessPlayers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chessPlayers == null)
            {
                return NotFound();
            }

            return View(chessPlayers);
        }

        // GET: ChessPlayers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChessPlayers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImieNazwisko,DataUrodzenia,Klub,Ranking")] ChessPlayers chessPlayers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chessPlayers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chessPlayers);
        }

        // GET: ChessPlayers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chessPlayers = await _context.ChessPlayers.FindAsync(id);
            if (chessPlayers == null)
            {
                return NotFound();
            }
            return View(chessPlayers);
        }

        // POST: ChessPlayers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImieNazwisko,DataUrodzenia,Klub,Ranking")] ChessPlayers chessPlayers)
        {
            if (id != chessPlayers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chessPlayers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChessPlayersExists(chessPlayers.Id))
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
            return View(chessPlayers);
        }

        // GET: ChessPlayers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chessPlayers = await _context.ChessPlayers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chessPlayers == null)
            {
                return NotFound();
            }

            return View(chessPlayers);
        }

        // POST: ChessPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chessPlayers = await _context.ChessPlayers.FindAsync(id);
            _context.ChessPlayers.Remove(chessPlayers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChessPlayersExists(int id)
        {
            return _context.ChessPlayers.Any(e => e.Id == id);
        }
    }
}
