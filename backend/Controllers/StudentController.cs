using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StudentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Students
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        // return await _context.Students.ToListAsync(); // Uncomment this line to return all students

        var student = new Student(
            1,
            "Mock Student",
            "mock@student.com",
            new DateTime(2000, 1, 1),
            new DateTime(2025, 2, 2)
        );
        return new List<Student> { student }; // Return a mock student for testing purposes
    }

    // GET: api/Students/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return NotFound();
        }
        return student;
    }

    // POST: api/Students
    [HttpPost]
    public async Task<ActionResult<Student>> PostStudent(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
    }

    // PUT: api/Students/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutStudent(int id, Student student)
    {
        if (id != student.Id)
        {
            return BadRequest();
        }
        _context.Entry(student).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Students/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return NotFound();
        }
        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}