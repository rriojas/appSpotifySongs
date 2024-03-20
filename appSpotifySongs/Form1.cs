using System.Data;

namespace appSpotifySongs
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      string query = "SELECT * FROM spotify_songs where track_artist='Maroon 5'";
      DataTable dataTable = Connection.GetDataTable(query);
      dataGridView1.DataSource = dataTable;
    }
  }
}
