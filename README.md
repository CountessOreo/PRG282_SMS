Student Management System (PRG2782)

A C# Windows Forms application for managing student records, built with version control using Git and GitHub. This project provides an easy-to-use interface for adding, viewing, updating, and deleting student records, with a summary report feature. Version control tracks each major update for reliable development.
Features
1. Add New Student

    Enter Student ID, Name, Age, and Course.
    Validates input fields to ensure data accuracy (e.g., age must be numeric).
    Appends new records to students.txt.

2. View All Students

    Displays all student records from students.txt in a DataGridView.
    Refreshes to show the latest data after additions, updates, or deletions.

3. Update Student Information

    Select a student record from the DataGridView for editing.
    Modify details in the form fields and save changes to students.txt.

4. Delete a Student

    Allows selecting a student from the DataGridView for deletion.
    Prompts for confirmation before removing the record, and refreshes the view.

5. Generate Summary Report

    Calculates the total number of students and the average age.
    Displays the results on the form and saves them to summary.txt.

Additionally a Login form was provided to show further implementation features.
