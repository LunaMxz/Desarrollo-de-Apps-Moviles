using System.Diagnostics;

namespace Mod2_UI;

public partial class Notes : ContentPage
{
    public const double MiTemaFuente = 28;
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
   
    public Notes()
	{
        InitializeComponent();
	}

    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}
