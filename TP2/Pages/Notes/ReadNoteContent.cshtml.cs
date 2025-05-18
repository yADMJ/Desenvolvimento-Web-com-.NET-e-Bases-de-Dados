using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

public class ReadNoteContentModel : PageModel
{
    public string FileName { get; set; }
    public string NoteContent { get; set; }

    public IActionResult OnGet(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            return NotFound();

        FileName = fileName;
        var filePath = Path.Combine("wwwroot/files", FileName);

        if (!System.IO.File.Exists(filePath))
            return NotFound();

        NoteContent = System.IO.File.ReadAllText(filePath);
        return Page();
    }
}
