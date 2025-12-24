# Laptop Rental System (SWE201 Term Project)

This project is intended as a term project assignment for the SWE201 course. 
It is a toy project which imitates the operations of a university technology lending desk where students can borrow devices like laptops.

The project structure consists of four main files (classes):

### 1. Device.cs
This class represents the real-world object (laptop/tablet) that is being rented.
Following the principles in your sample project, I packaged the attributes that identify the object.
* **Identifying Attributes:** `Id`, `Brand`, and `Model` are the properties that define what the device is.
* **Operational Properties:** `IsRented` is a property I added to store information about the "state" of the device. As you mentioned in the course notes, this is not an identifying attribute but a temporary status that changes during the operation.

### 2. Student.cs
This class represents the person renting the device.
It contains basic identifying information like `StudentNumber` and `FullName`. In a real-world scenario, this class would probably have more details, but I kept it to bare minimums for this specific application.

### 3. RentalManager.cs
In your sample project (`RentalVehicleApp`), you noted that letting the `Program` class handle operations is not the best design and suggested using a "Manager Class" for portability.
**Following your advice, I designed this `RentalManager` class.** * It acts as the "brain" of the application.
* It holds the `List<Device>` which simulates a database.
* It handles the creation (`AddNewDevice`), modification (`RentDevice`), and state changes (`ReturnDevice`) of the objects.
* This way, the main program logic is separated from the user interface (Console).

### 4. Program.cs
This is the entry point of the application. 
Thanks to the `RentalManager` class, `Program.cs` is very clean. It only handles the user input (Console.ReadLine) and calls the relevant methods from the manager.

## Design Decisions
* **Associations:** The `RentalManager` associates `Device` objects with `Student` information during the renting process.
* **Data Storage:** Since we are not using a SQL database yet, I used a generic `List<>` collection inside the manager to store the devices in memory while the program is running.
* **Why no separate Contract class?** For this specific "toy project", I decided to track the rental status directly on the `Device` object using the `IsRented` boolean for simplicity, rather than creating a complex contract object.

I tried to apply the OOP principles we learned in class to make the code clean and readable.