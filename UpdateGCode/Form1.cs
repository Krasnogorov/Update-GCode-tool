namespace UpdateGCode;

public partial class Form1 : Form
{
    private List<string> lines = new List<string>();
    private string fileName;
    public Form1()
    {
        InitializeComponent();
    }

    private void open_btn_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            fileName = openFileDialog.FileName;
            lines.Clear();
            FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() != -1)
            {
                string? line = reader.ReadLine();
                if (line != null)
                {
                    lines.Add(line);
                }
            }
        }
        textBox.Lines = lines.ToArray();
    }

    private void change_btn_Click(object sender, EventArgs e)
    {
        List<string> linesTmp = new List<string>();
        foreach (var line in lines)
        {
            if (line != null && line.Contains(textBox_commandToUpdate.Text) && !line.Contains(textBox_commandToIgnire.Text))
            {
                linesTmp.Add(textBox_insertBefore.Text);
                linesTmp.Add(line);
                linesTmp.Add(textBox_insertAfter.Text);
            }
            else if (line != null && line.Contains(textBox_endCommand.Text))
            {
                linesTmp.Add(textBox_insertBefore.Text);
                linesTmp.Add(line);
            }
            else
            {
                linesTmp.Add(line ?? "");
            }
        }
        lines.Clear();
        lines.AddRange(linesTmp.ToArray());
        textBox.Lines = lines.ToArray();
    }

    private void save_btn_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.OverwritePrompt = true;
        saveFileDialog.Filter = "GCode files (*.gc)|*.gc";
        saveFileDialog.FileName = fileName;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllLines(saveFileDialog.FileName, lines);
        }
    }

    private void checkBox_default_CheckedChanged_1(object sender, EventArgs e)
    {
        textBox_insertBefore.Enabled = !checkBox_default.Checked;
        textBox_commandToUpdate.Enabled = !checkBox_default.Checked;
        textBox_insertAfter.Enabled = !checkBox_default.Checked;
        textBox_commandToIgnire.Enabled = !checkBox_default.Checked;
        textBox_endCommand.Enabled = !checkBox_default.Checked;
    }
    
}