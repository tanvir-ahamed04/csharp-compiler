# C# Compiler Project

This project is a simple lexical and syntactical analyzer for a custom programming language. It performs lexical analysis to identify keywords, identifiers, constants, operators, and syntax analysis to validate the structure of the program.

## Table of Contents
- [Features](#features)
- [Setup](#setup)
- [Usage](#usage)
- [Code Structure](#code-structure)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Lexical Analysis**: Identifies keywords, identifiers, constants, and various operators.
- **Syntax Analysis**: Validates the structure of the program.
- **Visual Feedback**: Displays the analysis results in list boxes with color-coded highlighting.
- **Error Detection**: Highlights syntax errors with line and character position details.
- **Interactive UI**: Simple Windows Forms interface for input and output.

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/tanvir-ahamed04/csharp-compiler.git
   ```
2. Open the solution in Visual Studio.

3. Restore the NuGet packages if any.

4. Build the solution to resolve dependencies.

## Usage

1. Run the application in Visual Studio.

2. Input your program code in the provided text box.

3. Click the buttons to perform lexical and syntax analysis:
   - **Lexical Analysis**: Click the `Analyze Lexically` button.
   - **Syntax Analysis**: Click the `Analyze Syntax` button.

4. The results will be displayed in the list boxes:
   - The first list box will show the lexical analysis results.
   - The second list box will show any syntax errors and the syntax analysis results.

## Code Structure

- **Form1.cs**: Main form containing the logic for lexical and syntax analysis.
  - **Properties**:
    - `input_program`: Stores the input program code.
    - `input_pointer`, `num`, `text`, `line_number`, `char_position`: Various pointers and counters for analysis.
    - `identable`, `constable`: Instances of `Identable` and `Constable` classes to store identifiers and constants.
    - `presentInput`: Stores the current input token.

  - **Methods**:
    - `button1_Click`: Handles lexical analysis when the button is clicked.
    - `button2_Click`: Handles syntax analysis when the button is clicked.
    - `print`, `output`: Helper methods to print messages in the list boxes.
    - `nextInput`: Retrieves the next token from the input program.
    - `match`, `ParseProgram`, `parseIdentifierList`, etc.: Methods for syntax analysis.

- **Identable.cs**: Class to handle identifiers.
  - `clear`, `addidentifier`, `dump`: Methods to manage identifiers.

- **Constable.cs**: Class to handle constants.
  - `clear`, `add`, `dump`: Methods to manage constants.

## Contributing

Contributions are welcome! Please fork this repository and submit pull requests with your improvements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

```

This README file provides an overview of the project, its features, setup instructions, usage, code structure, and contribution guidelines.
