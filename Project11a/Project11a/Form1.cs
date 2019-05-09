using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project11a
{
    /// <summary>
    /// A Windows Froms application to process the "Books" Table.
    /// </summary>
    public partial class project11 : Form
    {
        /// <summary>
        /// Instance Variables
        /// </summary>
        private OleDbDataAdapter dataAdapterBooks;
        private OleDbConnection connectionBooks;
        private DataSet dataSetBooks;
        private DataTable dataTableBooks;
        private int index;
        
        /// <summary>
        /// Calls the "designer" methods to draw the form 
        /// </summary>
        public project11()
        {
            InitializeComponent();
        }

        private void project11_Load(object sender, EventArgs e)
        {
            try
            {
                dataAdapterBooks = new OleDbDataAdapter();
                connectionBooks = new OleDbConnection();
                connectionBooks.ConnectionString = Properties.Settings.Default.BooksConnectionString;
                dataSetBooks = new DataSet();
                dataTableBooks = dataSetBooks.Tables[0];

                OleDbCommand commandBooksSelect = new OleDbCommand();
                commandBooksSelect.CommandText = "SELECT * FROM Book";
                commandBooksSelect.Connection = connectionBooks;

                dataAdapterBooks.SelectCommand = commandBooksSelect;
                dataAdapterBooks.Fill(dataSetBooks);

                index = 0;
                findRow();

            }catch (Exception ex)
            {

            }
        }
        /// <summary>
        /// Find the record at the curent index location and call method currenRecord() to display it.
        /// </summary>
        private void findRow()
        {
            DataRow dataRowBooks = dataTableBooks.Rows[index];
            currentRecord(dataRowBooks);
        }

        /// <summary>
        /// Display the contents of the current row to the TextBoxes in the Form.
        /// </summary>
        /// <param name="dataRowBooks">The DataRow at the current index location</param>
        private void currentRecord(DataRow dataRowBooks)
        {
            textBoxTitle.Text = dataRowBooks["Title"].ToString();
            textBoxType.Text = dataRowBooks["Type"].ToString();
            textBoxPrice.Text = dataRowBooks["Price"].ToString();
            textBoxCode.Text = dataRowBooks["PublisherCode"].ToString();
            updateStatusBar();
        }

        /// <summary>
        /// Displays the current record number and number of records to the status bar.
        /// </summary>
        private void updateStatusBar()
        {
            statusStrip.Text = "Record " + (index + 1) + " of " + dataTableBooks.Rows.Count;
        }

        /// <summary>
        /// Sets the readOnly property of the textboxes based on machine state
        /// </summary>
        /// <param name="readOnly">specifies if the control should be read only</param>
        private void setReadOnly(bool readOnly)
        {
            textBoxPrice.ReadOnly = readOnly;
            textBoxType.ReadOnly = readOnly;
            textBoxTitle.ReadOnly = readOnly;
            textBoxCode.ReadOnly = readOnly;
        }

        /// <summary>
        /// Constants that represent the machine "state" for the application.
        /// </summary>
        private enum EditState
        {
            NOT_EDITING,
            ADDING,
            EDITING
        }

        /// <summary>
        /// Variable to store the current "state" of the application.
        /// </summary>
        private EditState editState;

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
