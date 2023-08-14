using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RpgApi.Models;
using RpgApi.Data;
using Microsoft.EntityFrameworkCore;
using RpgApi.Utils;

namespace RpgApi.Controllers
{
    public class ArmasController
    {
        [HttpPost]
        public async Task<IActionResult> Add(Arma novaArma)
        {
            try{
                if(novaArma.Dano == 0)
                throw new System.Exception("O dano da arma não pode ser 0");

                Personagem p = await _context.Personagens.FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId);

                if(p == null)
                throw new System.Exception("Não existe personagem com o Id informado. ");
                await _context.Armas.AddAsync(novaArma);
                await _context.SaveChangesAsync();
                return Ok(novaArma.Id);
            }
        }
    }
}