using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IO;

public class ReadNotesModel : PageModel
{
    public List<string> NoteFiles { get; set; } = new List<string>();

    public void OnGet()
    {
        var directory = Path.Combine("wwwroot/files");
        if (Directory.Exists(directory))
        {
            var files = Directory.GetFiles(directory, "*.txt");
            foreach (var file in files)
            {
                NoteFiles.Add(Path.GetFileName(file));
            }
        }
    }
}
