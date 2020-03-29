using CW3.DAL;
using CW3.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CW3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
           _dbService = dbService;
        }

        [HttpGet]
        public string GetStudent(string orderBy)
        {
            return $"Malewski, Andrzejewski, Kowalski sortowanie={orderBy}";
        }
        
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            switch (id)
            {
                case 1:
                    return Ok("Kowalski");

                case 2:
                    return Ok("Malewski");

                default:
                    return NotFound("Resource with id: " + id + " not found");
            }
        }
        
        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student student)
        {
            return Ok("Aktualizacja zakończona");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Usuwanie zakończone");
        }
    }
}