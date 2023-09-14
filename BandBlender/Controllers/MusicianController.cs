using Microsoft.AspNetCore.Mvc;
using BandBlender.Services;
using BandBlender.Models;
using BandBlender.Models.DTOs.Musician;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BandBlender.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicianController : ControllerBase
    {
        private readonly IMusicianService _musicianService;

        public MusicianController(IMusicianService musicianService)
        {
            _musicianService = musicianService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicianReadDto>>> GetAllMusicians()
        {
            var musicians = await _musicianService.GetAllMusicians();
            return Ok(musicians);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MusicianReadDto>> GetMusicianById(Guid id)
        {
            var musician = await _musicianService.GetMusicianById(id);

            if (musician == null)
            {
                return NotFound();
            }

            return Ok(musician);
        }

        [HttpPost]
        public async Task<ActionResult<MusicianReadDto>> CreateMusician(MusicianCreateDto musicianCreateDto)
        {
            var musicianId = await _musicianService.CreateMusician(musicianCreateDto);

            var musician = await _musicianService.GetMusicianById(musicianId);

            return CreatedAtAction(nameof(GetMusicianById), new { id = musicianId }, musician);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMusician(Guid id, MusicianUpdateDto musicianUpdateDto)
        {
            var existingMusician = await _musicianService.GetMusicianById(id);

            if (existingMusician == null)
            {
                return NotFound();
            }

            await _musicianService.UpdateMusician(id, musicianUpdateDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMusician(Guid id)
        {
            var existingMusician = await _musicianService.GetMusicianById(id);

            if (existingMusician == null)
            {
                return NotFound();
            }

            await _musicianService.DeleteMusician(id);

            return NoContent();
        }
    }
}
