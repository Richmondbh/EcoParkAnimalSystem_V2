
# EcoPark Animal Management System (EAMS) - Version 2

A Windows Forms application for managing animals in an eco-park, demonstrating advanced Object-Oriented Programming concepts in C#. (Second version of project 1 : https://github.com/Richmondbh/EcoParkAnimalManagementSystem-EAMS- )

##  Project Overview

This system allows users to create, manage, and track various animal species with their specific characteristics, dietary requirements, and scheduled events.

##  Features

- **Animal Management**: Add, modify, and delete animals from the system
- **Multiple Species Support**: 
  - Mammals: Dog, Cat
  - Reptiles: Snake, Turtle
- **Detailed Animal Information**:
  - General data (ID, name, age, weight, gender)
  - Category-specific attributes (teeth count, tail length, body length, etc.)
  - Species-specific traits (breed, fur color, venom status, shell width, etc.)
- **Advanced Features**:
  - Automatic ID generation with category prefixes (M100, R101, etc.)
  - Average lifespan calculation per species
  - Daily food requirement schedules
  - Upcoming events tracking (vet appointments, training, feeding)
  - Image upload for each animal

##  Architecture & OOP Concepts Implemented

### 1. **Inheritance Hierarchy**
```
IAnimal (Interface)
    ↓
Animal (Abstract Base Class)
    ↓
Mammal / Reptile (Abstract Category Classes)
    ↓
Dog, Cat / Snake, Turtle (Concrete Classes)
```

### 2. **Encapsulation**
- All fields are `private`
- Properties with validation for controlled access
- Data hiding with `protected` and `private` access modifiers

### 3. **Polymorphism**
- **Interface-based**: All animals implement `IAnimal`
- **Method overriding**: `ToString()`, `ToStringSummary()`
- **Abstract methods**: `GetAverageLifeSpan()`, `DailyFoodRequirement()`, `GetUpcomingEvents()`
- **Virtual methods**: `SetSleepTime()` with default implementation

### 4. **Abstraction**
- `IAnimal` interface defines contract
- Abstract classes (`Animal`, `Mammal`, `Reptile`) enforce structure
- Concrete classes provide specific implementations

### 5. **Generics**
- `IListManager<T>` - Generic interface for list operations
- `ListManager<T>` - Generic implementation for any type
- Type-safe collections with compile-time checking

### 6. **Design Patterns**
- **Factory Pattern**: `MammalFactory`, `ReptileFactory` for object creation
- **Inheritance**: Specialized classes inherit from generic base
- **Composition**: AnimalManager uses ListManager internally

##  Project Structure

```
EcoParkAnimalManagementSystem/
├── AnimalGen/
│   ├── Animal.cs (Abstract base class)
│   ├── CategoryType.cs (Enum)
│   └── GenderType.cs (Enum)
├── Infrastructure/
│   ├── IListManager.cs (Generic interface)
│   ├── ListManager.cs (Generic implementation)
│   └── AnimalManager.cs (Specialized for animals)
├── Interfaces/
│   └── IAnimal.cs (Animal contract)
├── Mammals/
│   ├── Mammal.cs (Abstract)
│   ├── MammalFactory.cs
│   ├── Dog.cs
│   ├── Cat.cs
│   └── MammalView.cs (Dialog)
├── Reptiles/
│   ├── Reptile.cs (Abstract)
│   ├── ReptileFactory.cs
│   ├── Snake.cs
│   ├── Turtle.cs
│   └── ReptileView.cs (Dialog)
├── Utilities/
│   └── NumericUtility.cs
└── MainForm.cs (Main interface)
```

##  Technical Implementation

### Data Structures Used
- **List<T>**: Dynamic animal storage
- **Dictionary<string, string>**: Food schedules (time → meal description)
- **Queue<string>**: Upcoming events in chronological order
- **Array**: Summary display formatting

### Key Classes

**ListManager<T>**: Generic collection manager
- Add, Delete, Change operations
- Index validation
- Type-safe operations

**AnimalManager**: Specialized animal collection
- Inherits from `ListManager<Animal>`
- ID generation with category prefixes
- Summary formatting for display
- Detailed information retrieval

**Animal Hierarchy**: 
- Abstract methods enforce implementation in concrete classes
- Virtual methods provide default behavior with override option
- Properties with validation ensure data integrity

##  Learning Outcomes

### Core OOP Principles
- Single Responsibility Principle
- Encapsulation with private fields and public properties
 Inheritance chains (3+ levels)
 Abstract classes vs. Interfaces
- Method overriding and polymorphism

### Advanced Concepts
- Generic types (`<T>`)
 Collections (List, Dictionary, Queue)
 Factory pattern for object creation
 Constructor chaining
 Type casting and conversion
 Dynamic binding

### C# Specific
 Properties (auto-properties, with validation)
String interpolation and formatting
 Enumerations
 XML documentation comments
 Windows Forms GUI development



##  Author

Richmond Boakye
- Course: Programming in C# II
- Institution: Malmö University

