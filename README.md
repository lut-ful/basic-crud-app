
# Basic CRUD Application Using C# and Windows Forms

## Overview
This project is a basic **CRUD (Create, Read, Update, Delete)** application developed using **C#** with **Windows Forms** as the user interface. It allows users to manage records in a database by performing the four basic operations on data: adding new records, retrieving/displaying records, updating existing records, and deleting records.

## Key Features
- **Create**: Add new records to the database through an input form.
- **Read**: Display existing records in a table or list.
- **Update**: Modify details of existing records.
- **Delete**: Remove records from the system.

## Tools and Technologies
- **Programming Language**: C#
- **User Interface**: Windows Forms (WinForms)
- **Database**: Microsoft SQL Server
- **IDE**: Visual Studio

## Project Workflow

### 1. User Interface (Windows Forms)
- **Main Form**: Contains buttons for Create, Edit, Read, Update, Delete, and Refresh operations, along with a `DataGridView` to display records.
- **Add/Edit Form**: A separate form to enter or modify record details.
- **Message Boxes**: Used for confirming actions such as deletion or record creation.

### 2. Database Operations
- **Create**: Add a new record by submitting a form.
- **Read**: Fetch and display records from the database in the `DataGridView`.
- **Update**: Edit an existing record by selecting it and submitting the modified data.
- **Delete**: Remove a record by selecting it and confirming deletion.

## Technical Steps

### 1. Database Setup
- Open the `.sql` file located in folder.
- Copy the queries from the `.sql` file and execute them in your new database to set up the schema and initial data.
- Use `Ctrl+F` to search for `connectionString` within the project files.
     ```csharp
     private readonly string connectionString = "Server=(localdb)\\login;Database=FinanceTracker;Trusted_Connection=True;";
   - Update this to:
     ```csharp
     private readonly string connectionString = "Server=<YOUR DATABASE SERVER/SOURCE>;Database=<DATABASENAME>;Trusted_Connection=True;";
-Database Schema.

![Screenshot 2024-09-13 012458](https://github.com/user-attachments/assets/1bd53e35-2260-413f-9b4e-cebeaae12356)


### 2. Form Design
- **DataGridView**: Displays records from the database.
- **Textboxes**: Input fields for adding/editing records.
- **Buttons**: Implement buttons for Create, Read, Update, Delete, and Refresh operations.
![Screenshot 2024-09-13 011050](https://github.com/user-attachments/assets/590ed2a7-0330-4d73-b071-1e1142ab75cf)


### 3. C# Code Implementation

#### Sample Add New Operation

```csharp
try
{
    if(MessageBox.Show("Are you sure you want to save this record? ","System Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
    {
        SqlConnection cn=new SqlConnection();
        cn.ConnectionString= "Data Source=LUTFUL-KABIR\\SQLEXPRESS;database=Crud_test;Integrated Security=True";
        SqlCommand cm=new SqlCommand();
        cm.Connection = cn;
        cn.Open();
        cm=new SqlCommand("insert into tblCrud (FirstName,MiddleName,LastName) values(@FirstName,@MiddleName,@LastName)",cn);
        cm.Parameters.AddWithValue("@FirstName",txtfirstname.Text);
        cm.Parameters.AddWithValue("@MiddleName",txtmiddlename.Text);
        cm.Parameters.AddWithValue("@LastName",txtlastname.Text);
        cm.ExecuteNonQuery();
        cn.Close();
        MessageBox.Show("Record has been successfully saved.","System Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        Clear();
        LoadEmployee();
    }
}
catch(Exception ex)
{
    MessageBox.Show(ex.Message,"System Message",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
}
```

### 4. Event Handling
- Implement event handlers for each button (e.g., `Create`, `Edit`, `Delete`).
- When a button is clicked, the corresponding CRUD operation will be executed (e.g., creating a new record or deleting an existing one).

## User Flow
1. When the application is opened, existing records are displayed in the `DataGridView`.
2. Users can:
   - **Add** new records by clicking the "Add" button and submitting the form.
   - **Edit** existing records by selecting a row and clicking the "Edit" button.
   - **Delete** records by selecting a row and confirming deletion.
   - **Refresh** the displayed data to reflect the latest updates from the database.

## Challenges and Considerations
- **Data Validation**: Ensure proper input validation for fields.
- **Error Handling**: Implement error handling for database connection failures or invalid inputs.

## Further Enhancements
- **Search Functionality**: Add a search bar to filter records.

## How to Run the Project
1. **Clone the Repository**: Clone this repository to your local machine.
   ```bash
   git clone https://github.com/lut-ful/basic-crud-app
   ```
2. **Set Up the Database**: Configure your SQL Server or SQLite database and update the connection according to the `script.sql` file.
3. **Build the Project**: Open the project in Visual Studio and build the solution.
4. **Run the Application**: Once built, run the application and manage records through the Windows Forms interface.
