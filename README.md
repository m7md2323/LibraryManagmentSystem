# LibraryManagmentSystem

For Backend Node.js & express js

Database MongoDB

C# for handling the logic

WPF (XAML) for UI/UX (Frontend)


[LibraryManagmentSystem(Requirement Specifications).txt](https://github.com/user-attachments/files/18695262/LibraryManagmentSystem.txt)
1. Library Management System
Project Description:
The Library Management System is designed to help librarians and readers manage books, loans, and returns efficiently. It reduces manual paperwork and automates library operations.

**System Entities and Data**:

Book:

[

  Unique Book ID
  
  Title
  
  Author
  
  Genre
  
  Status (available/borrowed)
  
]

Reader:

[

  Unique Reader ID
  
  Name
  
  Phone Number
  
  Borrowed Books List
  
]

Loan:

[

  Loan ID
  
  Book ID
  
  Reader ID
  
  Borrow Date
  
  Return Date
  
  Status (borrowed/returned)
  
]

Fine:

[

  Fine ID
  
  Reader ID
  
  Amount
  
  Status (paid/unpaid)
  
]

**Use Cases**:

For Readers:

[

 1.Search for books
 
 2.Borrow a book
 
 3.Return a book
 
 4.Pay a fine
 
 5.View borrowed books
 
]

For Librarians:

[

 1.Add/update book information
 
 2.View all books and loans
 
 3.View overdue books
 
 4.Manage fines
 
 5.Generate reports
 
]

**Implementation Details**:

1.Use C# and file-based storage.

2.Enforce borrowing limits and due dates.

3.Readers cannot borrow books if they have unpaid fines.

