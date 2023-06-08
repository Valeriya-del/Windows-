using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Windowsпроб
//   // class sql
// {
// }

//Создание бд - CREATE DATABASE (ИМЯ) 
/* 
 * 
 * CREATE TABLE Diagnosis
(
dz_id int NOT NULL PRIMARY KEY IDENTITY (1,1),
dz_name nvarchar(200) NOT NULL
)
GO

 * 
 * CREATE TABLE Medical_card
(
mc_id int NOT NULL PRIMARY KEY IDENTITY (1,1),
mc_name nvarchar(200) NOT NULL
)
GO

 * 
 * 
 * 
 * 
 * CREATE TABLE Patient
(
p_id int NOT NULL PRIMARY KEY IDENTITY (1,1),
p_name nvarchar(200) NOT NULL,
p_date_of_birth date NOT NULL,
p_adress nvarchar(200) NOT NULL,
p_phone tinyint NOT NULL,
p_diagnosis int references Diagnosis (dz_id) NOT NULL,
p_mc int references Medical_card (mc_id) NOT NULL 
)
GO

    Заполнение 
    SET IDENTITY_INSERT Doctor ON;
INSERT INTO Doctor 
(d_id,d_name,d_date_of_birth,d_adress,d_specialization,d_category)
VALUES 
(1, 'Иванов Иван Иванович', '1990-03-01', 'г.Ростов-на-Дону, ул.Ленина 23', 
'Терапевт', 1),
(2, 'Петров Петр Петрович', '1981-12-12', 'г.Новочеркасск, ул.Бакунина 66', 
'Хирург', 1),
(3, 'Антонов Антон Антонович', '1979-05-10', 'г.Ростов-на-Дону, 
ул.Мироновская 1', 'Невролог', 1),
(4, 'Лебедев Георгий Александрович', '1987-01-12', 'г.Новочеркасск, ул.Святая 
80', 'Отоларинголог', 1),
(5, 'Широкина Виктория Валерьевна', '2000-09-07', 'г.Ростов-на-Дону, 
ул.Нагибина 44', 'Офтальмолог', 1),
(6, 'Миронова Ангелина Николаевна', '1969-01-01', 'г.Новочеркасск, 
ул.Московская 54', 'Травматолог', 1),
(7, 'Ручкина Маргарита Алексеевна', '1999-04-09', 'г.Ростов-на-Дону, 
ул.Доломанова 81', 'Инфекционист', 1),
(8, 'Васильева Екатерина Александровна', '1982-02-02', 'г.Новочеркасск, 
ул.Пушкинская 12', 'Стоматолог', 1);
SET IDENTITY_INSERT Doctor OFF;



    USE "training"
SELECT p_student, s_fio,st_name,  p_timestamp, p_status       
FROM performance
INNER JOIN students 
ON p_student=s_id
INNER JOIN tasks
ON p_task=t_id
INNER JOIN steps
ON p_step=st_id

namespace 
{
 public partial class MainForm : Form
 {
 public MainForm()
 {
 InitializeComponent();
 }
 private void Form1_Load(object sender, EventArgs e)
 {
 }
 private void SpecialtyButton_Click(object sender, EventArgs e)
 {
 SpecialtyForm form = new SpecialtyForm();
 form.Show();
 }
 private void ItemsButton_Click(object sender, EventArgs e)
 {
 ItemsForm form = new ItemsForm();
 form.Show();
 }
 private void StudentsButton_Click(object sender, EventArgs e)
 {
 StudentsForm form = new StudentsForm();
 form.Show();
 }
 private void GradesButton_Click(object sender, EventArgs e)
 {
 GradesForm form = new GradesForm();
 form.Show();
 }
 }
}


namespace 
{
 public partial class SpecialtyForm : Form
 {
 public SpecialtyForm()
 {
 InitializeComponent();
 }
 private void специальностиBindingNavigatorSaveItem_Click(object sender,
EventArgs e)
 {
 this.Validate();
 this.специальностиBindingSource.EndEdit();
 this.tableAdapterManager.UpdateAll(this.student_KalaydaDataSet);
 }
 private void SpecialtyForm_Load(object sender, EventArgs e)
 {

this.специальностиTableAdapter.Fill(this.student_KalaydaDataSet.Специальности);
 }
 }
}


{
 public partial class StudentsForm : Form
 {
 public StudentsForm()
 {
 InitializeComponent();
 }
 private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs
e)
45
 {
 this.Validate();
 this.студентыBindingSource.EndEdit();
 this.tableAdapterManager.UpdateAll(this.student_KalaydaDataSet);
 }
 private void StudentsForm_Load(object sender, EventArgs e)
 {
this.специальностиTableAdapter.Fill(this.student_KalaydaDataSet.Специальности);
 this.студентыTableAdapter.Fill(this.student_KalaydaDataSet.Студенты);
 }
 private void FirstButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MoveFirst();
 }
 private void PreviosButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MovePrevious();
 }
 private void PastButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MoveLast();
 }
 private void NextButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.MoveNext();
 }
 private void AddButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.AddNew();
 }
 private void DeleteButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.RemoveCurrent();
 }
 private void SaveButton_Click(object sender, EventArgs e)
 {
 this.Validate();
 this.студентыBindingSource.EndEdit();
 this.tableAdapterManager.UpdateAll(this.student_KalaydaDataSet);
 }
 private void TableButton_Click(object sender, EventArgs e)
 {
 StudentTableForm form = new StudentTableForm();
 form.Show();
 }
 }
}





{
 public partial class StudentTableForm : Form
 {
 public StudentTableForm()
 {
 InitializeComponent();
 }
 private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs
e)
 {
 this.Validate();
 this.студентыBindingSource.EndEdit();
 this.tableAdapterManager.UpdateAll(this.student_KalaydaDataSet);
 }
 private void StudentTableForm_Load(object sender, EventArgs e)
 {
 this.студентыTableAdapter.Fill(this.student_KalaydaDataSet.Студенты);
 }
 private void SortListBox_SelectedIndexChanged(object sender, EventArgs e)
 {
 SortButton.Enabled = true;
 }
 private void SortButton_Click(object sender, EventArgs e)
 {
47
 DataGridViewColumn Col = dataGridViewTextBoxColumn2;
 switch (SortListBox.SelectedIndex)
 {
 case 0:
 Col = dataGridViewTextBoxColumn2;
break;
 case 1:
 Col = dataGridViewTextBoxColumn3;
break;
 case 2:
 Col = dataGridViewTextBoxColumn4;
break;
 case 3:
 Col = dataGridViewTextBoxColumn5;
break;
 case 4:
 Col = dataGridViewTextBoxColumn6;
break;
 case 5:
 Col = dataGridViewTextBoxColumn7;
break;
 case 6:
 Col = dataGridViewTextBoxColumn8;
break;
 case 7:
 Col = dataGridViewTextBoxColumn9;
break;
 case 8:
 Col = dataGridViewTextBoxColumn10;
break;
 case 9:
 Col = dataGridViewTextBoxColumn11;
break;
 case 10:
 Col = dataGridViewTextBoxColumn12;
break;
 }
 if (AscendingRadioButton.Checked) студентыDataGridView.Sort(Col,
System.ComponentModel.ListSortDirection.Ascending);
 else студентыDataGridView.Sort(Col,
System.ComponentModel.ListSortDirection.Descending);
 }
 private void FilterButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.Filter = "ФИО='" + FIOcomboBox.Text + "'";
 }
 private void ShowButton_Click(object sender, EventArgs e)
 {
 студентыBindingSource.Filter = "";
 }
 private void SearchButton_Click(object sender, EventArgs e)
 {
 int i = 0;
 int j = 0;
 for (i = 0; i < студентыDataGridView.ColumnCount - 1; i++)
 {
 for (j = 0; j < студентыDataGridView.RowCount - 1; j++)
 {
 студентыDataGridView.Rows[j].Cells[i].Style.BackColor =
Color.White;
48
 студентыDataGridView.Rows[j].Cells[i].Style.ForeColor =
Color.Black;
 }
 }
 for (i = 0; i < студентыDataGridView.ColumnCount; i++)
 {
 for (j = 0; j < студентыDataGridView.RowCount; j++)
 {
 var val = студентыDataGridView.Rows[j].Cells[i].Value;
if (val != null)
{
 string vals = val.ToString();
 if (vals.IndexOf(SearchtextBox.Text) > -1)
{
 студентыDataGridView.Rows[j].Cells[i].Style.BackColor =
Color.AliceBlue;
 студентыDataGridView.Rows[j].Cells[i].Style.ForeColor =
Color.Blue;
 }
 }
 }
 }
 }
 private void CloseButton_Click(object sender, EventArgs e)
 {
 this.Close();
 }
 }
}





















*/








