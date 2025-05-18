using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

public class SaveNoteModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public string FileName { get; set; }

    public void OnPost()
    {
        if (!ModelState.IsValid)
            return;

        var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        FileName = $"note-{timestamp}.txt";
        var filePath = Path.Combine("wwwroot/files", FileName);

        Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

        System.IO.File.WriteAllText(filePath, Input.Content);
    }


    public class InputModel
    {
        [Required(ErrorMessage = "O conteúdo da nota é obrigatório.")]
        public string Content { get; set; }
    }
}
