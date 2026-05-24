using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class Index1Model : PageModel
{
    [BindProperty] public int? TextBox1 { get; set; }
    [BindProperty] public int? TextBox2 { get; set; }
    [BindProperty] public int? TextBox3 { get; set; }

    public List<string> Hatalar { get; set; } = new();

    public double Ortalama { get; set; }

    public bool Basarili { get; set; }

    public void OnPost()
    {
        Hatalar.Clear();
        Basarili = false;

        if (TextBox1 == null) Hatalar.Add("1. yazılı boş bırakılamaz");
        if (TextBox2 == null) Hatalar.Add("2. yazılı boş bırakılamaz");
        if (TextBox3 == null) Hatalar.Add("Sözlü boş bırakılamaz");

        if (TextBox1 != null && (TextBox1 < 0 || TextBox1 > 100))
            Hatalar.Add("1. yazılı 0-100 arası olmalı");

        if (TextBox2 != null && (TextBox2 < 0 || TextBox2 > 100))
            Hatalar.Add("2. yazılı 0-100 arası olmalı");

        if (TextBox3 != null && (TextBox3 < 0 || TextBox3 > 100))
            Hatalar.Add("Sözlü 0-100 arası olmalı");

        if (Hatalar.Count == 0)
        {
            Ortalama = (TextBox1!.Value + TextBox2!.Value + TextBox3!.Value) / 3.0;
            Basarili = true;
        }
    }
}