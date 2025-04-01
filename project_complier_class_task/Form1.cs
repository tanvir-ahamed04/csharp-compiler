namespace project_complier_class_task
{
    public partial class Form1 : Form
    {
        private string input_program;
        private int input_pointer;
        private int num;
        private string text;
        private int line_number;
        private int char_position;
        private identifierTable identable;
        private Constable constable;
        private twoTuple presentInput;
        private tempVarTable tempvartable;
        private fourTupleTable middlecodetable;

        public Form1()
        {
            InitializeComponent();
            input_program = string.Empty;
            text = string.Empty;
            identable = new identifierTable();
            constable = new Constable();
            presentInput = new twoTuple(string.Empty, string.Empty);
            tempvartable = new tempVarTable();
            middlecodetable = new fourTupleTable(); // Add this line
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            identable.clear();
            constable.clear();
            listBox1.Items.Add("Lexical analysis Output:  ");

            if (textBox1.Text == "")
            {
                listBox1.Items.Add("no input");
                return;
            }

            input_program = textBox1.Text + "#";
            input_pointer = 0;
            num = 1;
            text = "";
            line_number = 1; // Initialize line number
            char_position = 1; // Initialize character position

            // Full lexical analysis logic
            while (input_program[input_pointer] != '#')
            {
                char c = input_program[input_pointer];
                if (c == ' ')
                {
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (c == '\n' || c == '\r')
                {
                    line_number++; // Increment line number on newline
                    char_position = 1; // Reset character position
                    input_pointer++;
                    continue;
                }
                if (num == 1 && c == '$')
                {
                    num = 2;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 2 && c >= 'a' && c <= 'z')
                {
                    num = 3;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                switch (num)
                {
                    case 3:
                        if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                        {
                            num = 3;
                            text += c;
                            input_pointer++;
                            char_position++;
                            continue;
                        }
                        identable.addidentifier(text);
                        listBox1.Items.Add(new twoTuple("identifier", text));
                        text = "";
                        num = 1;
                        break;
                    case 1:
                        if (c >= '0' && c <= '9')
                        {
                            num = 4;
                            text += c;
                            input_pointer++;
                            char_position++;
                            continue;
                        }
                        break;
                }
                switch (num)
                {
                    case 4:
                        if (c >= '0' && c <= '9')
                        {
                            num = 4;
                            text += c;
                            input_pointer++;
                            char_position++;
                            continue;
                        }
                        constable.add(text);
                        listBox1.Items.Add(new twoTuple("constant", text));
                        text = "";
                        num = 1;
                        break;
                    case 1:
                        if (c == 'i')
                        {
                            num = 6;
                            text += c;
                            input_pointer++;
                            char_position++;
                            continue;
                        }
                        break;
                }
                if (num == 6 && c == 'f')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("keyword if", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 6 && c == 'n')
                {
                    num = 8;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 8 && c == 't')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("variable description", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == 't')
                {
                    num = 10;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 10 && c == 'h')
                {
                    num = 11;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 11 && c == 'e')
                {
                    num = 12;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 12 && c == 'n')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("keyword then", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == 'd')
                {
                    num = 13;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 13 && c == 'o')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("keyword do", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == 'w')
                {
                    num = 15;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 15 && c == 'h')
                {
                    num = 16;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 16 && c == 'i')
                {
                    num = 17;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 17 && c == 'l')
                {
                    num = 18;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 18 && c == 'e')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("keyword while", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == 'b')
                {
                    num = 20;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 20 && c == 'e')
                {
                    num = 21;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 21 && c == 'g')
                {
                    num = 22;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 22 && c == 'i')
                {
                    num = 23;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 23 && c == 'n')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("keyword begin", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == 'e')
                {
                    num = 25;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 25 && c == 'n')
                {
                    num = 26;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 26 && c == 'd')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("keyword end", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 25 && c == 'l')
                {
                    num = 28;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 28 && c == 's')
                {
                    num = 29;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 29 && c == 'e')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("keyword else", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == ';')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("separator semicolon", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == ',')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("separator comma", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == '(')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("left bracket", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == ')')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("right bracket", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == '+')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("add operator", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == '*')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("mul operator", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == '<')
                {
                    num = 31;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                switch (num)
                {
                    case 31:
                        if (c == '=')
                        {
                            text += c;
                            input_pointer++;
                            char_position++;
                            listBox1.Items.Add(new twoTuple("logical operator", text));
                            text = "";
                            num = 1;
                            continue;
                        }
                        listBox1.Items.Add(new twoTuple("logical operator", text));
                        text = "";
                        num = 1;
                        break;
                    case 1:
                        if (c == '>')
                        {
                            num = 33;
                            text += c;
                            input_pointer++;
                            char_position++;
                            continue;
                        }
                        break;
                }
                switch (num)
                {
                    case 33:
                        if (c == '=')
                        {
                            text += c;
                            input_pointer++;
                            char_position++;
                            listBox1.Items.Add(new twoTuple("logical operator", text));
                            text = "";
                            num = 1;
                            continue;
                        }
                        listBox1.Items.Add(new twoTuple("logical operator", text));
                        text = "";
                        num = 1;
                        break;
                    case 1:
                        if (c == '!')
                        {
                            num = 35;
                            text += c;
                            input_pointer++;
                            char_position++;
                            continue;
                        }
                        break;
                }
                if (num == 35 && c == '=')
                {
                    text += c;
                    input_pointer++;
                    char_position++;
                    listBox1.Items.Add(new twoTuple("logical operator", text));
                    text = "";
                    num = 1;
                    continue;
                }
                if (num == 1 && c == '=')
                {
                    num = 37;
                    text += c;
                    input_pointer++;
                    char_position++;
                    continue;
                }
                if (num == 37)
                {
                    if (c == '=')
                    {
                        text += c;
                        input_pointer++;
                        char_position++;
                        listBox1.Items.Add(new twoTuple("logical operator", text));
                        text = "";
                        num = 1;
                        continue;
                    }
                    listBox1.Items.Add(new twoTuple("assignment operator", text));
                    text = "";
                    num = 1;
                    continue;
                }

                input_pointer++;
                listBox1.Items.Add(new twoTuple($"Keyword error (Line {line_number}, Char {char_position})", text));
                text = "";
                num = 1;
            }

            listBox1.Items.Add("");
            listBox1.Items.Add("identifier table: " + identable.dump());
            listBox1.Items.Add("const table: " + constable.dump());

            listBox1.Items.Add("");
            listBox1.Items.Add(new twoTuple("Compiler Author", "Tanvir Ahamed"));
        }



        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            identable.clear();
            constable.clear();
            listBox1.Items.Add("Syntex analysis Output:  ");
            listBox1.Items.Add("");

            if (((Control)textBox1).Text == "")
            {
                //Add "no input" to listBox1
                listBox1.Items.Add((object)"no input");
                return;
            }
            //Set the input_program to the text in textBox1 plus a "#" character
            input_program = ((Control)textBox1).Text + "#";
            input_pointer = 0;
            presentInput = nextInput();
            print("[#](" + presentInput.type + ", " + presentInput.value + ")");
            ParseProgram();
            listBox1.Items.Add("");
            print("Syntax analysis completed.");
            print("identifier table: " + identable.dump());
            print("const table: " + constable.dump());

            listBox1.Items.Add("");
            listBox1.Items.Add(new twoTuple($"Compiler Author", "Tanvir Ahamed"));


        }


        private void print(string str)
        {
            listBox1.Items.Add((object)str);
        }

        private void output(string str)
        {
            //Add the string to the second list box
            listBox2.Items.Add((object)str);
        }

        private class twoTuple
        {
            // This property represents the type of the tuple
            public string type { get; set; }

            // This property represents the value of the tuple
            public string value { get; set; }

            // This constructor initializes the type and value of the tuple
            public twoTuple(string type, string value)
            {
                this.type = type;
                this.value = value;
            }

            public override string ToString()
            {
                return $"({this.type},{this.value})";
            }
        }


        private twoTuple nextInput()
        {
            // Initialize variables
            string text = "";
            int num = 1;
            // Loop until the end of the input program is reached
            while (input_program[input_pointer] != '#')
            {
                // Get the current character from the input program
                char c = input_program[input_pointer];
                // If the character is a space, move to the next character
                if (c == ' ')
                {
                    input_pointer++;
                    continue;
                }
                // If the character is a dollar sign and num is 1, set num to 2 and add the character to the text
                if (num == 1 && c == '$')
                {
                    num = 2;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If the character is a lowercase letter and num is 2, set num to 3 and add the character to the text
                if (num == 2 && c >= 'a' && c <= 'z')
                {
                    num = 3;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // Switch statement to handle different cases based on the value of num
                switch (num)
                {
                    case 3:
                        // If the character is a lowercase letter or a digit, add the character to the text and continue
                        if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                        {
                            num = 3;
                            text += c;
                            input_pointer++;
                            continue;
                        }
                        // Add the identifier to the identable and return a twoTuple with the identifier and its type
                        identable.addidentifier(text);
                        return new twoTuple("identifier", text);
                    case 1:
                        // If the character is a digit, set num to 4 and add the character to the text
                        if (c >= '0' && c <= '9')
                        {
                            num = 4;
                            text += c;
                            input_pointer++;
                            continue;
                        }
                        break;
                }
                // Switch statement to handle different cases based on the value of num
                switch (num)
                {
                    case 4:
                        // If the character is a digit, add the character to the text and continue
                        if (c >= '0' && c <= '9')
                        {
                            num = 4;
                            text += c;
                            input_pointer++;
                            continue;
                        }
                        // Add the constant to the constable and return a twoTuple with the constant and its type
                        constable.add(text);
                        return new twoTuple("constant", text);
                    case 1:
                        // If the character is an 'i', set num to 6 and add the character to the text
                        if (c == 'i')
                        {
                            num = 6;
                            text += c;
                            input_pointer++;
                            continue;
                        }
                        break;
                }
                // If num is 6 and the character is an 'f', return a twoTuple with the keyword "if" and its type
                if (num == 6 && c == 'f')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("keyword if", text);
                }
                // If num is 6 and the character is an 'n', set num to 8 and add the character to the text
                if (num == 6 && c == 'n')
                {
                    num = 8;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 8 and the character is a 't', return a twoTuple with the keyword "variable description" and its type
                if (num == 8 && c == 't')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("variable description", text);
                }
                // If num is 1 and the character is a 't', set num to 10 and add the character to the text
                if (num == 1 && c == 't')
                {
                    num = 10;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 10 and the character is a 'h', set num to 11 and add the character to the text
                if (num == 10 && c == 'h')
                {
                    num = 11;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 11 and the character is an 'e', set num to 12 and add the character to the text
                if (num == 11 && c == 'e')
                {
                    num = 12;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 12 and the character is an 'n', return a twoTuple with the keyword "then" and its type
                if (num == 12 && c == 'n')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("keyword then", text);
                }
                // If num is 1 and the character is a 'd', set num to 13 and add the character to the text
                if (num == 1 && c == 'd')
                {
                    num = 13;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 13 and the character is an 'o', return a twoTuple with the keyword "do" and its type
                if (num == 13 && c == 'o')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("keyword do", text);
                }
                // If num is 1 and the character is a 'w', set num to 15 and add the character to the text
                if (num == 1 && c == 'w')
                {
                    num = 15;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 15 and the character is a 'h', set num to 16 and add the character to the text
                if (num == 15 && c == 'h')
                {
                    num = 16;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 16 and the character is an 'i', set num to 17 and add the character to the text
                if (num == 16 && c == 'i')
                {
                    num = 17;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 17 and the character is a 'l', set num to 18 and add the character to the text
                if (num == 17 && c == 'l')
                {
                    num = 18;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 18 and the character is an 'e', return a twoTuple with the keyword "while" and its type
                if (num == 18 && c == 'e')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("keyword while", text);
                }
                // If num is 1 and the character is a 'b', set num to 20 and add the character to the text
                if (num == 1 && c == 'b')
                {
                    num = 20;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 20 and the character is an 'e', set num to 21 and add the character to the text
                if (num == 20 && c == 'e')
                {
                    num = 21;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 21 and the character is a 'g', set num to 22 and add the character to the text
                if (num == 21 && c == 'g')
                {
                    num = 22;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 22 and the character is an 'i', set num to 23 and add the character to the text
                if (num == 22 && c == 'i')
                {
                    num = 23;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 23 and the character is an 'n', return a twoTuple with the keyword "begin" and its type
                if (num == 23 && c == 'n')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("keyword begin", text);
                }
                // If num is 1 and the character is an 'e', set num to 25 and add the character to the text
                if (num == 1 && c == 'e')
                {
                    num = 25;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 25 and the character is an 'n', set num to 26 and add the character to the text
                if (num == 25 && c == 'n')
                {
                    num = 26;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 26 and the character is a 'd', return a twoTuple with the keyword "end" and its type
                if (num == 26 && c == 'd')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("keyword end", text);
                }
                // If num is 25 and the character is a 'l', set num to 28 and add the character to the text
                if (num == 25 && c == 'l')
                {
                    num = 28;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 28 and the character is a 's', set num to 29 and add the character to the text
                if (num == 28 && c == 's')
                {
                    num = 29;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // If num is 29 and the character is an 'e', return a twoTuple with the keyword "else" and its type
                if (num == 29 && c == 'e')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("keyword else", text);
                }
                // If num is 1 and the character is a semicolon, return a twoTuple with the separator "semicolon" and its type
                if (num == 1 && c == ';')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("separator semicolon", text);
                }
                // If num is 1 and the character is a comma, return a twoTuple with the separator "comma" and its type
                if (num == 1 && c == ',')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("separator comma", text);
                }
                // If num is 1 and the character is a left bracket, return a twoTuple with the left bracket and its type
                if (num == 1 && c == '(')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("left bracket", text);
                }
                // If num is 1 and the character is a right bracket, return a twoTuple with the right bracket and its type
                if (num == 1 && c == ')')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("right bracket", text);
                }
                // If num is 1 and the character is an addition operator, return a twoTuple with the addition operator and its type
                if (num == 1 && c == '+')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("add operator", text);
                }
                // If num is 1 and the character is a multiplication operator, return a twoTuple with the multiplication operator and its type
                if (num == 1 && c == '*')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("mul operator", text);
                }
                // If num is 1 and the character is a less than operator, set num to 31 and add the character to the text
                if (num == 1 && c == '<')
                {
                    num = 31;
                    text += c;
                    input_pointer++;
                    continue;
                }
                // Switch statement to handle different cases based on the value of num
                switch (num)
                {
                    case 31:
                        // If the character is an equal sign, return a twoTuple with the logical operator and its type
                        if (c == '=')
                        {
                            text += c;
                            input_pointer++;
                            return new twoTuple("logical operator", text);
                        }
                        // Otherwise, return a twoTuple with the logical operator and its type
                        return new twoTuple("logical operator", text);
                    case 1:
                        if (c == '>')
                        {
                            num = 33;
                            text += c;
                            input_pointer++;
                            continue;
                        }
                        break;
                }
                switch (num)
                {
                    case 33:
                        if (c == '=')
                        {
                            text += c;
                            input_pointer++;
                            return new twoTuple("logical operator", text);
                        }
                        return new twoTuple("logical operator", text);
                    case 1:
                        if (c == '!')
                        {
                            num = 35;
                            text += c;
                            input_pointer++;
                            continue;
                        }
                        break;
                }
                if (num == 35 && c == '=')
                {
                    text += c;
                    input_pointer++;
                    return new twoTuple("logical operator", text);
                }
                if (num == 1 && c == '=')
                {
                    num = 37;
                    text += c;
                    input_pointer++;
                    continue;
                }
                if (num == 37)
                {
                    if (c == '=')
                    {
                        text += c;
                        input_pointer++;
                        return new twoTuple("logical operator", text);
                    }
                    return new twoTuple("assignment operator", text);
                }
                input_pointer++;
                return new twoTuple("error", "error");
            }
            return new twoTuple("#", "#");
        }




        private bool match(string type)
        {
            if (presentInput.type == type)
            {
                print("[Syntax]matching " + type + ", read head: " + presentInput.type + ", match successful");

                presentInput = nextInput();

                print("[Syntax](" + presentInput.type + ", " + presentInput.value + ")");

                if (presentInput.type == "#")
                {

                    print("Lexical Analysis Complete with syntax Analysis");
                }

                return true;
            }
            //Print a message indicating that the match failed
            print("[Syntax]matching " + type + ", read head: " + presentInput.type + ", match failed");
            //Return false to indicate that the match failed
            return false;
        }

        private bool ParseProgram()
        {
            print("[Syntax] Derivation: <Program> → <Variable Declaration Part>;<Statement Part>");

            if (ParseVarExplainSection())
            {
                if (match("separator semicolon"))
                {
                    if (parseStatementSection())
                    {
                        return true; // Ensure a return value
                    }
                    else
                    {
                        print("Error: Failed to parse statement section.");
                        return false;
                    }
                }
                else
                {
                    print("Error: Missing semicolon after variable declaration part.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to parse variable declaration part.");
                return false;
            }
        }



        private bool parseIdentifierList()
        {
            print("[Syntax] Derivation: <Identifier List> → <Identifier> <Identifier List Prime>");

            if (match("identifier"))
            {
                if (parseIdentifierListPrime())
                {
                    return true;
                }
                else
                {
                    print("Error: Failed to parse identifier list prime.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to match identifier.");
                return false;
            }
        }


        private bool parseIdentifierListPrime()
        {
            if (presentInput.type == "separator comma")
            {
                print("[Syntax] Derivation: <Identifier List Prime> → ,<Identifier> <Identifier List Prime>");

                match("separator comma");
                match("identifier");
                parseIdentifierListPrime();
                return true;
            }
            else
            {
                print("[Syntax] Derivation: <Identifier List Prime> → ε");
                return true;
            }

        }


        private bool parseStatementSection()
        {
            print("[Syntax] Derivation: <Statement Section>  → <Statement> ; <Statement Section Prime>");

            if (parseStatement())
            {
                if (match("separator semicolon"))
                {
                    if (parseStatementSectionPrime())
                    {
                        return true;
                    }
                    else
                    {
                        print("Error: Failed to parse statement section prime.");
                        return false;
                    }
                }
                else
                {
                    print("Error: Missing semicolon after statement.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to parse statement.");
                return false;
            }
        }



        private bool parseStatementSectionPrime()
        {

            if (presentInput.type == "identifier" || presentInput.type == "keyword if" || presentInput.type == "keyword while")
            {

                print("[Syntax] Derivation: <Statement Section Prime> → <Statement>;<Statement Section Prime>");

                parseStatement();

                match("separator semicolon");

                parseStatementSectionPrime();
                return true;
            }

            else
            {

                print("[Syntax] Derivation: <Statement Section Prime> → ε");
                return true;
            }

        }


        private bool parseStatement()
        {

            if (presentInput.type == "identifier")
            {

                print("[Syntax] Derivation: <Statement> → <Assign Statement>");

                parseAssignStatement();
                return true;
            }

            else if (presentInput.type == "keyword if")
            {

                print("[Syntax] Derivation: <Statement> → <If Statement>");
                parseIfStatement();
                return true;
            }
            else if (presentInput.type == "keyword while")
            {
                print("[Syntax] Derivation: <Statement> → <While Statement>");
                parseWhileStatement();
                return true;
            }
            return false;
        }


        private bool parseAssignStatement()
        {
            print("[Syntax] Derivation: <Assign Statement> → <Identifier> = <Expression>");

            if (match("identifier"))
            {
                if (match("assignment operator"))
                {
                    if (parseExpression())
                    {
                        return true;
                    }
                    else
                    {
                        print("Error: Failed to parse expression.");
                        return false;
                    }
                }
                else
                {
                    print("Error: Failed to match assignment operator.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to match identifier.");
                return false;
            }
        }



        private bool parseExpression()
        {
            print("[Syntax] Derivation: <Expression> → <Expression Item> <Expression Prime>");

            if (parseExpressionItem())
            {
                if (parseExpressionPrime())
                {
                    return true;
                }
                else
                {
                    print("Error: Failed to parse expression prime.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to parse expression item.");
                return false;
            }
        }



        private bool parseExpressionPrime()
        {

            if (presentInput.type == "add operator")
            {

                print("[Syntax] Derivation: <Expression Prime> → + <Expression Item> <Expression Prime>");

                match("add operator");

                parseExpressionItem();
                parseExpressionPrime();
                return true;
            }
            else
            {
                print("[Syntax] Derivation: <Expression Prime> → ε");
                return true;
            }

        }


        private bool parseExpressionItem()
        {
            print("[Syntax] Derivation: <Expression Item> → <Expression Factor> <Expression Item Prime>");

            if (parseExpressionFactor())
            {
                if (parseExpressionItemPrime())
                {
                    return true;
                }
                else
                {
                    print("Error: Failed to parse expression item prime.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to parse expression factor.");
                return false;
            }
        }



        private bool parseExpressionItemPrime()
        {

            if (presentInput.type == "mul operator")
            {

                print("[Syntax] Derivation: <Expression Item Prime> → <Multiplication Operator> <Expression Factor> <Expression Item Prime>");

                match("mul operator");

                parseExpressionFactor();

                parseExpressionItemPrime();
                return true;
            }

            else
            {
                print("[Syntax] Derivation: <Expression Item Prime> → ε");
                return true;
            }

        }


        private bool parseExpressionFactor()
        {

            if (presentInput.type == "identifier")
            {
                print("[Syntax]Derivation: <Factor> → <Identifier>");

                match("identifier");
                return true;
            }

            else if (presentInput.type == "constant")
            {
                print("[Syntax]Derivation: <Factor> → <Constant>");
                match("constant");
                return true;
            }
            // Else if the present input is a left bracket
            else if (presentInput.type == "left bracket")
            {
                // Print the derivation of a factor being an expression in brackets
                print("[Syntax]Derivation: <Factor> → (<Expression>)");
                // Parse the expression
                match("left bracket");
                parseExpression();
                match("right bracket");
                return true;
            }
            return false;
        }

        // This method parses an if statement
        private bool parseIfStatement()
        {
            print("[Syntax]Derivation: <Conditional Statement> → if (<Condition>) then <Nested Statement>; else <Nested Statement>");

            if (match("keyword if"))
            {
                if (match("left bracket"))
                {
                    if (parseLogicExpression())
                    {
                        if (match("right bracket"))
                        {
                            if (match("keyword then"))
                            {
                                if (parseNestedStatement())
                                {
                                    if (match("separator semicolon"))
                                    {
                                        if (match("keyword else"))
                                        {
                                            if (parseNestedStatement())
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                print("Error: Failed to parse nested statement after else.");
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            print("Error: Failed to match keyword else.");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        print("Error: Missing semicolon after nested statement.");
                                        return false;
                                    }
                                }
                                else
                                {
                                    print("Error: Failed to parse nested statement after then.");
                                    return false;
                                }
                            }
                            else
                            {
                                print("Error: Failed to match keyword then.");
                                return false;
                            }
                        }
                        else
                        {
                            print("Error: Failed to match right bracket.");
                            return false;
                        }
                    }
                    else
                    {
                        print("Error: Failed to parse logic expression.");
                        return false;
                    }
                }
                else
                {
                    print("Error: Failed to match left bracket.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to match keyword if.");
                return false;
            }
        }

        // This method parses a logical expression
        private bool parseLogicExpression()
        {
            print("[Syntax]Derivation: <Condition> → <Expression><Relational Operator><Expression>");

            if (parseExpression())
            {
                if (match("logical operator"))
                {
                    if (parseExpression())
                    {
                        return true;
                    }
                    else
                    {
                        print("Error: Failed to parse second expression.");
                        return false;
                    }
                }
                else
                {
                    print("Error: Failed to match logical operator.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to parse first expression.");
                return false;
            }
        }

        //This method parses a nested statement-----------------------here!
        private bool parseNestedStatement()
        {
            //If the present input is an identifier, keyword if, or keyword while
            if (presentInput.type == "identifier" || presentInput.type == "keyword if" || presentInput.type == "keyword while")
            {
                //Print the derivation of the nested statement
                print("[Syntax]Derivation: <Nested Statement> → <Statement>");
                parseStatement();
                return true;
            }
            else if (presentInput.type == "keyword begin")
            {
                print("[Syntax]Derivation: <Nested Statement> → <Compound Statement>");
                parseCompoundStatement();
                return true;
            }
            return false;
        }

        // This method parses a compound statement
        private bool parseCompoundStatement()
        {
            print("[Syntax]Derivation: <Compound Statement> → begin <Statement Part> end");

            if (match("keyword begin"))
            {
                if (parseStatementSection())
                {
                    if (match("keyword end"))
                    {
                        return true;
                    }
                    else
                    {
                        print("Error: Failed to match keyword end.");
                        return false;
                    }
                }
                else
                {
                    print("Error: Failed to parse statement section.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to match keyword begin.");
                return false;
            }
        }

        // This method parses a while statement
        private bool parseWhileStatement()
        {
            print("[Syntax]Derivation: <Loop Statement> → while (<Condition>) do <Nested Statement>");

            if (match("keyword while"))
            {
                if (match("left bracket"))
                {
                    if (parseLogicExpression())
                    {
                        if (match("right bracket"))
                        {
                            if (match("keyword do"))
                            {
                                if (parseNestedStatement())
                                {
                                    return true;
                                }
                                else
                                {
                                    print("Error: Failed to parse nested statement.");
                                    return false;
                                }
                            }
                            else
                            {
                                print("Error: Failed to match keyword do.");
                                return false;
                            }
                        }
                        else
                        {
                            print("Error: Failed to match right bracket.");
                            return false;
                        }
                    }
                    else
                    {
                        print("Error: Failed to parse logic expression.");
                        return false;
                    }
                }
                else
                {
                    print("Error: Failed to match left bracket.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to match keyword while.");
                return false;
            }
        }
        private bool ParseVarExplainSection()
        {
            print("[Syntax] Derivation: <Variable Declaration Part> → <Variable Declaration> <Identifier List>");

            if (match("variable description"))
            {
                if (parseIdentifierList())
                {
                    return true;
                }
                else
                {
                    print("Error: Failed to parse identifier list.");
                    return false;
                }
            }
            else
            {
                print("Error: Failed to match variable description.");
                return false;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();


            //Clear the tables
            identable.clear();
            constable.clear();
            tempvartable.clear();
            middlecodetable.clear();

            listBox2.Items.Add("Mid-Code Output:  ");
            //Check if the textBox1 is empty
            if (textBox1.Text == "")
            {
                listBox1.Items.Add((object)"no input");
                return;
            }
            input_program = textBox1.Text + "#";
            input_pointer = 0;
            presentInput = nextInput();
            print("[#](" + presentInput.type + ", " + presentInput.value + ")");
            if (translateProgram())
            {
                print("Syntax analysis completed.");
                output("Target code:");
            }
            print("identifier table: " + identable.dump());
            print("const table: " + constable.dump());
            print("temp var table: " + tempvartable.dump());
            middlecodetable.dump(listBox2);


            listBox2.Items.Add("");
            listBox2.Items.Add(new twoTuple($"Compiler Author", "Tanvir Ahamed"));
        }


        private class Identifier
        {
            // The name of the identifier
            public string Name { get; set; }

            // The type of the identifier
            public string Type { get; set; }

            // The value of the identifier
            public string Value { get; set; }

            public Identifier(string name)
            {
                this.Name = name;
                Type = "";
                Value = "";
            }

            //This method returns the value of the object as an int32
            public int getValueAsInt32()
            {
                //Check if the value is not an empty string
                if (Value != "")
                {
                    try
                    {
                        //Try to convert the value to an int32
                        return Convert.ToInt32(Value);
                    }
                    catch (Exception)
                    {
                        //If an exception is thrown, show an error message
                        MessageBox.Show("Error:" + Name + ", " + Type + ", " + Value);
                    }
                }
                //Return -1 if the value is an empty string
                return -1;
            }
        }

        private class identifierTable
        {
            // Define a list to store Identifier objects
            private List<Identifier> table;

            // Constructor to initialize the list
            public identifierTable()
            {
                table = new List<Identifier>();
            }

            // Method to check if an identifier with the given name exists in the table
            public bool ExistIdentifier(string name)
            {
                foreach (Identifier item in table)
                {
                    if (item.Name == name)
                    {
                        return true;
                    }
                }
                return false;
            }

            // Method to add an identifier to the table
            public bool addidentifier(string str)
            {
                // Check if the identifier already exists
                if (ExistIdentifier(str))
                {
                    return false;
                }
                // Add the identifier to the table
                table.Add(new Identifier(str));
                return true;
            }

            // Method to get the index of an identifier in the table by its name
            //This method returns the index of an identifier in the table based on its name
            private int getIdentifierIndexByName(string name)
            {
                //Loop through the table
                for (int i = 0; i < table.Count; i++)
                {
                    //If the name of the identifier at index i matches the given name
                    if (table[i].Name == name)
                    {
                        //Return the index
                        return i;
                    }
                }
                //If no match is found, return -1
                return -1;
            }

            // Method to get the value of an identifier in the table by its name
            //This method returns the value of a given name
            public string getValueByName(string name)
            {
                //Get the index of the identifier by name
                int identifierIndexByName = getIdentifierIndexByName(name);
                //If the index is -1, the name does not exist
                if (identifierIndexByName == -1)
                {
                    return "name not exist";
                }
                //Return the value of the identifier
                return table[identifierIndexByName].Value;
            }

            // Method to get the value of an identifier in the table by its name as an integer
            //This method returns the value of a given name as an integer
            public int getValueByNameAsInt(string name)
            {
                //Get the index of the identifier by name
                int identifierIndexByName = getIdentifierIndexByName(name);
                //If the identifier is not found, return -1
                if (identifierIndexByName == -1)
                {
                    return -1;
                }
                //Return the value of the identifier as an integer
                return table[identifierIndexByName].getValueAsInt32();
            }

            // Method to update the value of an identifier in the table by its name
            //This method updates the value of a table entry by name
            public bool updateValueByName(string name, string value)
            {
                //Get the index of the identifier by name
                int identifierIndexByName = getIdentifierIndexByName(name);
                //If the identifier is not found, return false
                if (identifierIndexByName == -1)
                {
                    return false;
                }
                //Update the value of the table entry at the given index
                table[identifierIndexByName].Value = value;
                //Return true to indicate that the value was updated
                return true;
            }

            // Method to get the type of an identifier in the table by its name
            public string getTypeByName(string name)
            {
                int identifierIndexByName = getIdentifierIndexByName(name);
                if (identifierIndexByName == -1)
                {
                    return "name not exist";
                }
                return table[identifierIndexByName].Type;
            }

            // Method to input the type of an identifier in the table by its name
            //This method takes in a name and a type and assigns the type to the identifier with the given name
            public bool inputTypeByName(string name, string type)
            {
                //Get the index of the identifier with the given name
                int identifierIndexByName = getIdentifierIndexByName(name);
                //If the identifier does not exist, return false
                if (identifierIndexByName == -1)
                {
                    return false;
                }
                //If the identifier already has a type, return false
                if (table[identifierIndexByName].Type != "")
                {
                    return false;
                }
                //Assign the type to the identifier
                table[identifierIndexByName].Type = type;
                return true;
            }

            // Method to dump the contents of the table
            public string dump()
            {
                string text = "";
                foreach (Identifier item in table)
                {
                    text += item.Name;
                    text = ((!(item.Type == "")) ? (text + ", " + item.Type) : (text + ", {type} "));
                    text = ((!(item.Value == "")) ? (text + ", " + item.Value + "; ") : (text + ", {value}; "));
                }
                return text;
            }

            // Method to clear the contents of the table
            public void clear()
            {
                table.Clear();
            }
        }


        private bool translateProgram()
        {
            // Print the derivation of the program
            print("[Syntax]Derivation: <Program> → <Variable Explanation Section>;<Statement Section>#");
            // If the variable explanation section cannot be translated, output an error message and return false
            if (!translateVarExplainSection())
            {
                output("Semantic Error: Failed to translate <Variable Explanation Section>");
                return false;
            }
            // If the separator semicolon is not matched, output an error message and return false
            if (!match("separator semicolon"))
            {
                output("Syntax Error: Missing separator");
                return false;
            }
            // If the statement section cannot be translated, output an error message and return false
            if (!translateStatementSection())
            {
                output("Semantic Error: Failed to translate <Statement Section>");
                return false;
            }
            // Return true if the program is successfully translated
            return true;
        }

        private bool translateVarExplainSection()
        {
            // Print the syntax for the variable declaration
            print("[Syntax]Derivation: <Variable Declaration> → int <Identifier List>");
            if (!match("variable description"))
            {
                output("Syntax Error: Missing Variable Declaration");
                return false;
            }
            if (!translateIdentifierList("int"))
            {
                output("Semantic Error: Failed to translate Identifier List");
                return false;
            }
            return true;
        }

        // This function checks if the input is an identifier and assigns it a type
        private bool translateIdentifierList(string type)
        {
            // Print the derivation of the syntax rule
            print("[Syntax]Derivation: <Identifier List> → <Identifier> <Identifier List Prime>");
            // Check if the input is an identifier
            if (presentInput.type != "identifier")
            {
                // Output an error message if the input is not an identifier
                output("Syntax error: Missing identifier");
                return false;
            }
            // Check if the identifier already has a type
            if (identable.getTypeByName(presentInput.value) != "" && identable.getTypeByName(presentInput.value) != "int")
            {
                // Output an error message if the identifier already has a type
                output("Semantic error: Type conflict for identifier " + presentInput.value);
                return false;
                // If the identifier does not have a type, assign it a type
            }
            if (identable.getTypeByName(presentInput.value) == "")
            {
                if (!identable.inputTypeByName(presentInput.value, type))
                {
                    output("Program error: Failed to update type of identifier " + presentInput.value);
                    return false;
                }
                print("[Translation]Assign type 'int' to identifier " + presentInput.value + ";");
                match("identifier");
            }
            if (!translateIdentifierListPrime(type))
            {
                output("Semantic error: Failed to translate <Identifier List Prime> 1");
                return false;
            }
            return true;
        }

        // This method checks if the input is a comma and if so, it matches it and checks if the identifier is valid
        // If the identifier is valid, it updates its type and then recursively calls the method to check the next identifier
        // If the input is not a comma, it returns true
        private bool translateIdentifierListPrime(string type)
        {
            // Check if the input is a comma
            if (presentInput.type == "separator comma")
            {
                // Print the derivation of the syntax
                print("[Syntax]Derivation: <Identifier List Prime> → , <Identifier> <Identifier List Prime>");
                match("separator comma");
                if (presentInput.type != "identifier")
                {
                    output("Syntax error: Missing identifier");
                    return false;
                }
                if (identable.getTypeByName(presentInput.value) != "" && identable.getTypeByName(presentInput.value) != "int")
                {
                    output("Semantic error: Identifier " + presentInput.value + " has a type conflict");
                    return false;
                }
                if (identable.getTypeByName(presentInput.value) == "")
                {
                    if (!identable.inputTypeByName(presentInput.value, type))
                    {
                        output("Program error: Failed to update the type of identifier " + presentInput.value);
                        return false;
                    }
                    print("[Translation]Fill the type of identifier " + presentInput.value + " with int;");
                    match("identifier");
                }
                if (!translateIdentifierListPrime(type))
                {
                    output("Semantic error: Failed to translate <Identifier List Prime>2");
                    return false;
                }
                return true;
            }
            print("[Syntax]Derivation: <Identifier List Prime> → ε");
            return true;
        }

        // This method translates a statement section
        private bool translateStatementSection()
        {
            // Print the derivation of the statement section
            print("[Syntax]Derivation: <StatementSection> → <Statement>;<StatementSectionPrime>");
            // If the statement cannot be translated, output an error message and return false
            if (!translateStatement())
            {
                output("Semantic error: Failed to translate <Statement>1");
                return false;
            }
            // If the semicolon is not matched, output an error message and return false
            if (!match("separator semicolon"))
            {
                output("Syntax error: Missing Delimiter Semicolon");
                return false;
            }
            // If the statement section prime cannot be translated, output an error message and return false
            if (!translateStatementSectionPrime())
            {
                output("Semantic error: Failed to translate <StatementSectionPrime>1");
                return false;
            }
            // If all translations are successful, return true
            return true;
        }

        // This method checks if the present input is an identifier, keyword if, or keyword while
        private bool translateStatementSectionPrime()
        {
            if (presentInput.type == "identifier" || presentInput.type == "keyword if" || presentInput.type == "keyword while")
            {
                // Print the derivation of the statement section prime
                print("[Syntax]Derivation: <statement section prime> -> <statement>; <statement section prime>");
                if (!translateStatement())
                {
                    output("Semantic error: failed to translate <statement>2");
                    return false;
                }
                if (!match("separator semicolon"))
                {
                    output("Syntax error: missing separator semicolon");
                    return false;
                }
                if (!translateStatementSectionPrime())
                {
                    output("Semantic error: failed to translate <statement section prime>2");
                    return false;
                }
                return true;
            }
            print("[Syntax]Derivation: <statement section prime> -> ε");
            return true;
        }

        // This function checks the type of the present input and translates the statement accordingly
        private bool translateStatement()
        {
            // If the present input is an identifier, translate the assignment statement
            if (presentInput.type == "identifier")
            {
                print("[Syntax]Derivation: <statement> -> <assignment statement>");
                // If the assignment statement cannot be translated, output an error message and return false
                if (!translateAssignStatement())
                {
                    output("Semantic error: failed to translate <assignment statement>");
                    return false;
                }
            }
            // If the present input is a keyword if, translate the conditional statement
            else if (presentInput.type == "keyword if")
            {
                print("[Syntax]Derivation: <statement> -> <conditional statement>");
                // If the conditional statement cannot be translated, output an error message and return false
                if (!translateIfStatement())
                {
                    output("Semantic error: failed to translate <conditional statement>");
                    return false;
                }
            }
            // If the present input is a keyword while, translate the loop statement
            else
            {
                // If the present input is not a keyword while, output a syntax error message and return false
                if (!(presentInput.type == "keyword while"))
                {
                    print("Syntax error: unrecognized statement");
                    return false;
                }
                print("[Syntax]Derivation: <statement> -> <loop statement>");
                // If the loop statement cannot be translated, output an error message and return false
                if (!translateWhileStatement())
                {
                    output("Semantic error: failed to translate <loop statement>");
                    return false;
                }
            }
            // If the statement can be translated, return true
            return true;
        }

        // This method translates an assignment statement
        private bool translateAssignStatement()
        {
            // Print the derivation of the assignment statement
            print("[Syntax]Derivation: <assignment statement> -> <identifier> = <expression>");
            // Check if the present input is an identifier
            if (presentInput.type != "identifier")
            {
                // Print a syntax error message
                print("Syntax error: missing identifier");
                return false;
            }
            // Check if the identifier exists in the identable
            if (!identable.ExistIdentifier(presentInput.value))
            {
                // Print a semantic error message
                output("Semantic error: identifier " + presentInput.value + " is undefined");
                return false;
            }
            Identifier identifier = new Identifier(presentInput.value);
            identifier.Type = presentInput.type;
            match("identifier");
            print("Translation: Obtaining the identifier for assignment statement: " + identifier.Name);
            if (!match("assignment operator"))
            {
                print("Syntax error: missing assignment operator");
                return false;
            }
            Identifier identifier2 = translateExpression();
            if (identifier2 == null)
            {
                output("Semantic error: failed to evaluate <expression>");
                return false;
            }
            if (identifier2.getValueAsInt32() == -1)
            {
                output("Semantic error: error occurred during expression evaluation");
                return false;
            }
            middlecodetable.add("=", identifier2.Name, "null", identifier.Name);
            identable.updateValueByName(identifier.Name, identifier2.Value);
            print("Translation: Outputting quadruple of assignment statement");
            print("Translation: Updating value of identifier " + identifier.Name + " to " + identifier2.Value);
            return true;
        }

        // This method translates an expression
        private Identifier translateExpression()
        {
            print("[Syntax]Derivation: <expression> → <term><expressionPrime>");
            Identifier identifier = translateExpressionItem();
            if (identifier == null)
            {
                output("Semantic error: failed to evaluate <term>");
                return new Identifier("error") { Type = "error", Value = "error" };
            }
            Identifier identifier2 = translateExpressionPrime(identifier);
            if (identifier2 == null)
            {
                output("Semantic error: failed to evaluate <expressionPrime>");
                return new Identifier("error") { Type = "error", Value = "error" };
            }
            return identifier2;
        }

        // This method translates the expression prime
        private Identifier translateExpressionPrime(Identifier operator1)
        {
            if (presentInput.type == "add operator")
            {
                print("[Syntax]Derivation: <expression prime> → <addition operator> <term> <expression prime>");
                match("add operator");
                Identifier identifier = translateExpressionItem();
                if (identifier == null)
                {
                    output("Semantic error: <term> calculation error");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                Identifier identifier2 = tempvartable.createTempVar();
                print("[Translation]: Create temporary variable for addition operation");
                middlecodetable.add("+", operator1.Name, identifier.Name, identifier2.Name);
                print("[Translation]: Generate quadruple for addition operation");
                identifier2.Type = "int";
                identifier2.Value = (operator1.getValueAsInt32() + identifier.getValueAsInt32()).ToString();
                Identifier identifier3 = translateExpressionPrime(identifier2);
                if (identifier3 == null)
                {
                    output("Semantic error: <expression prime> calculation error");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                return identifier3;
            }
            print("[Syntax]Derivation: <expression prime>  → ε");
            return operator1;
        }

        // This method translates an expression item
        private Identifier translateExpressionItem()
        {
            print("[Syntax]Derivation: <term> → <factor><termPrime>");
            Identifier identifier = translateExpressionFactor();
            if (identifier == null)
            {
                output("Semantic error: Calculation error in <factor>");
                return new Identifier("error") { Type = "error", Value = "error" };
            }
            Identifier identifier2 = translateExpressionItemPrime(identifier);
            if (identifier2 == null)
            {
                output("Semantic error: Calculation error in <termPrime>");
                return new Identifier("error") { Type = "error", Value = "error" };
            }
            return identifier2;
        }

        // This method translates the expression item prime
        private Identifier translateExpressionItemPrime(Identifier operator1)
        {
            if (presentInput.type == "mul operator")
            {
                print("[Syntax]Derivation: <termPrime> → <multiplication operator> <factor> <termPrime>");
                match("mul operator");
                Identifier identifier = translateExpressionFactor();
                if (identifier == null)
                {
                    output("Semantic error: Calculation error in <factor>");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                Identifier identifier2 = tempvartable.createTempVar();
                print("[Translation]: Create temporary variable for multiplication operation");
                middlecodetable.add("*", operator1.Name, identifier.Name, identifier2.Name);
                print("[Translation]: Generate quadruple for multiplication operation");
                identifier2.Value = (identifier.getValueAsInt32() * operator1.getValueAsInt32()).ToString();
                identifier2.Type = "int";
                Identifier identifier3 = translateExpressionItemPrime(identifier2);
                if (identifier3 == null)
                {
                    output("Semantic error: Calculation error in <termPrime>");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                return identifier3;
            }
            print("[Syntax]Derivation: <termPrime> → ε");
            return operator1;
        }

        // This method translates an expression factor
        private Identifier translateExpressionFactor()
        {
            if (presentInput.type == "identifier")
            {
                print("[Syantax]Derivation: <Factor> → <Identifier>");
                string value = presentInput.value;
                if (!identable.ExistIdentifier(value))
                {
                    output("Semantic Error: Identifier " + value + " is undefined");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                if (identable.getValueByName(value) == "")
                {
                    output("Semantic Error: Identifier " + value + " lacks an initial value");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                Identifier identifier = new Identifier(value);
                identifier.Type = identable.getTypeByName(value);
                identifier.Value = identable.getValueByName(value);
                print("[Translation]Get the value of the identifier in the expression");
                match("identifier");
                return identifier;
            }
            if (presentInput.type == "constant")
            {
                Identifier identifier2 = new Identifier(presentInput.value);
                identifier2.Type = "int";
                identifier2.Value = presentInput.value;
                print("[Syantax]Derivation: <Factor> → <Constant>");
                match("constant");
                return identifier2;
            }
            if (presentInput.type == "left bracket")
            {
                print("[Syntax]Derivation: <Factor> → (<Expression>)");
                match("left bracket");
                Identifier identifier3 = translateExpression();
                if (identifier3 == null)
                {
                    output("Semantic Error: Error calculating the expression");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                match("right bracket");
                return identifier3;
            }
            return new Identifier("error") { Type = "error", Value = "error" };
        }

        // This method translates an if statement
        private bool translateIfStatement()
        {
            // Declare three integer variables
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            // Print the derivation of the if statement
            print("[Syntax]Derivation: <Conditional statement> → if (<Condition>) then <Nested statement>; else <Nested statement>");
            // Match the keyword "if"
            match("keyword if");
            // Match the left bracket
            match("left bracket");
            // Translate the logic expression and store the result in an Identifier object
            Identifier identifier = translateLogicExpression();
            // If the Identifier object is null, print an error message and return false
            if (identifier == null)
            {
                output("Semantic error: Translation error in <Condition>");
                return false;
            }
            // Store the current value of NXQ + 2 in the num variable
            num = middlecodetable.NXQ + 2;
            // Add a jump quadruple to the middle code table
            middlecodetable.add("jnz", identifier.Name, "null", num.ToString());
            // Print a message indicating that the jump quadruple for the true branch of the if statement has been generated
            print("[Translation]Generating the jump quadruple for true branch of the if statement");
            middlecodetable.add("j", "null", "null", "0");
            print("[Translation]Generating the jump quadruple for false branch of the if statement");
            num2 = middlecodetable.getLastItemIndex();
            match("right bracket");
            match("keyword then");
            if (!translateNestedStatement())
            {
                output("Semantic error: Translation error in <Nested statement>");
                return false;
            }
            middlecodetable.updateResultbyIndex(num2, (middlecodetable.NXQ + 1).ToString());
            print("[Translation]Backfilling the address of false branch of the if statement");
            middlecodetable.add("j", "null", "null", "0");
            print("[Translation]Generating the jump quadruple for exit of the if statement");
            num3 = middlecodetable.getLastItemIndex();
            match("separator semicolon");
            match("keyword else");
            if (!translateNestedStatement())
            {
                output("Semantic error: Translation error in <Nested statement>");
                return false;
            }
            middlecodetable.updateResultbyIndex(num3, middlecodetable.NXQ.ToString());
            print("[Translation]Backfilling the address of exit of the if statement");
            return true;
        }

        private Identifier translateLogicExpression()
        {
            print(" [Syntax]Derivation: <Condition> → <Expression> <Relational Operator> <Expression>");
            Identifier identifier = translateExpression();
            if (identifier == null)
            {
                output("Semantic error: <Expression> calculation error.");
                return new Identifier("error") { Type = "error", Value = "error" };
            }
            string text = "";
            if (presentInput.type == "logical operator")
            {
                text = presentInput.value;
                match("logical operator");
                Identifier identifier2 = translateExpression();
                if (identifier2 == null)
                {
                    output("Semantic error: <Expression> calculation error.");
                    return new Identifier("error") { Type = "error", Value = "error" };
                }
                Identifier identifier3 = tempvartable.createTempVar();
                identifier3.Type = "bool";
                switch (text)
                {
                    case "==":
                        middlecodetable.add("==", identifier.Name, identifier2.Name, identifier3.Name);
                        print("[Translation]Generate quadruple for equal operation.");
                        if (identifier.Value == identifier2.Value)
                        {
                            identifier3.Value = "true";
                        }
                        else
                        {
                            identifier3.Value = "false";
                        }
                        return identifier3;
                    case "!=":
                        middlecodetable.add("!=", identifier.Name, identifier2.Name, identifier3.Name);
                        print("[Translation]Generate quadruple for not equal operation.");
                        if (identifier.Value != identifier2.Value)
                        {
                            identifier3.Value = "true";
                        }
                        else
                        {
                            identifier3.Value = "false";
                        }
                        return identifier3;
                    case "<":
                        middlecodetable.add("<", identifier.Name, identifier2.Name, identifier3.Name);
                        print("[Translation]Generate quadruple for less than operation.");
                        if (identifier.getValueAsInt32() < identifier2.getValueAsInt32())
                        {
                            identifier3.Value = "true";
                        }
                        else
                        {
                            identifier3.Value = "false";
                        }
                        return identifier3;
                    case ">":
                        middlecodetable.add(">", identifier.Name, identifier2.Name, identifier3.Name);
                        print("[Translation]Generate quadruple for greater than operation.");
                        if (identifier.getValueAsInt32() > identifier2.getValueAsInt32())
                        {
                            identifier3.Value = "true";
                        }
                        else
                        {
                            identifier3.Value = "false";
                        }
                        return identifier3;
                    case "<=":
                        middlecodetable.add("<=", identifier.Name, identifier2.Name, identifier3.Name);
                        print("[Translation]Generate quadruple for less than or equal to operation.");
                        if (identifier.getValueAsInt32() <= identifier2.getValueAsInt32())
                        {
                            identifier3.Value = "true";
                        }
                        else
                        {
                            identifier3.Value = "false";
                        }
                        return identifier3;
                    case ">=":
                        middlecodetable.add(">=", identifier.Name, identifier2.Name, identifier3.Name);
                        print("[Translation]Generate quadruple for greater than or equal to operation.");
                        if (identifier.getValueAsInt32() > identifier2.getValueAsInt32())
                        {
                            identifier3.Value = "true";
                        }
                        else
                        {
                            identifier3.Value = "false";
                        }
                        return identifier3;
                    default:
                        print("Syntax error: Unrecognized logical operator.");
                        return new Identifier("error") { Type = "error", Value = "error" };
                }
            }
            print("Syntax error: Missing logical operator.");
            return new Identifier("error") { Type = "error", Value = "error" };
        }

        // This method checks if the present input is an identifier, keyword if, or keyword while, and if so, it translates the nested statement as a statement. 
        // If the present input is a keyword begin, it translates the nested statement as a compound statement. 
        // If the present input is none of the above, it returns false.
        private bool translateNestedStatement()
        {
            // Check if the present input is an identifier, keyword if, or keyword while
            if (presentInput.type == "identifier" || presentInput.type == "keyword if" || presentInput.type == "keyword while")
            {
                // Print the derivation for the nested statement
                print("[Syntax]Derivation: <Nested Statement> → <Statement>");
                // Translate the nested statement as a statement
                if (!translateStatement())
                {
                    // Output a semantic error if there is a translation error for the statement
                    output("Semantic error: Translation error for <Statement> in nested statement.");
                    return false;
                }
                return true;
            }
            // Check if the present input is a keyword begin
            if (presentInput.type == "keyword begin")
            {
                // Print the derivation for the nested statement
                print("[Syntax]Derivation: <Nested Statement> → <Compound Statement>");
                if (!translateCompoundStatement())
                {
                    output("Semantic error: Translation error for <Compound Statement>.");
                    return false;
                }
                return true;
            }
            return false;
        }

        // This method checks if the compound statement is valid
        private bool translateCompoundStatement()
        {
            // Print the derivation of the compound statement
            print("[Syntax]Derivation: <Compound Statement> → begin <Statement Part> end");
            // Check if the keyword 'begin' is present
            if (!match("keyword begin"))
            {
                // If not, output a syntax error
                output("Syntax error: Missing 'begin'.");
                return false;
            }
            // Check if the statement section is valid
            if (!translateStatementSection())
            {
                // If not, output a semantic error
                output("Semantic error: Translation error for <Statement Part> in compound statement.");
                return false;
            }
            if (!match("keyword end"))
            {
                output("Syntax error: Missing 'end'.");
                return false;
            }
            return true;
        }

        // This method translates a while statement
        private bool translateWhileStatement()
        {
            // Print the derivation of the while statement
            print("[Syntax]Derivation: <Loop Statement> → while (<Condition>) do <Nested Statement>");
            int nXQ = middlecodetable.NXQ;
            if (!match("keyword while"))
            {
                output("Syntax error: Missing 'while'.");
                return false;
            }
            if (!match("left bracket"))
            {
                output("Syntax error: Missing '('.");
                return false;
            }
            Identifier identifier = translateLogicExpression();
            if (identifier == null)
            {
                output("Semantic error: Translation error for <Condition>.");
                return false;
            }
            middlecodetable.add("jnz", identifier.Name, "null", (middlecodetable.NXQ + 2).ToString());
            print("[Translation]Generate quadruple for jumping to start of while statement.");
            middlecodetable.add("j", "null", "null", "0");
            print("[Translation]Generate quadruple for jumping to exit of while statement.");
            int lastItemIndex = middlecodetable.getLastItemIndex();
            if (!match("right bracket"))
            {
                output("Syntax error: Missing ')'.");
                return false;
            }
            if (!match("keyword do"))
            {
                output("Syntax error: Missing 'do'.");
                return false;
            }
            if (!translateNestedStatement())
            {
                output("Semantic error: Translation error for nested statement.");
                return false;
            }
            middlecodetable.add("j", "null", "null", nXQ.ToString());
            print("[Translation]Generate quadruple for jumping back to the beginning of while statement.");
            middlecodetable.updateResultbyIndex(lastItemIndex, middlecodetable.NXQ.ToString());
            print("[Translation]Backpatch the exit of while statement.");
            return true;
        }



        private class fourTuple
        {
            // Define a public string property called operand
            public string operand { get; set; }

            // Define a public string property called operator1
            public string operator1 { get; set; }

            // Define a public string property called operator2
            public string operator2 { get; set; }

            // Define a public string property called result
            public string result { get; set; }

            // Define a constructor for the fourTuple class
            public fourTuple(string operand, string operator1, string operator2, string result)
            {
                // Set the operand property to the value passed in
                this.operand = operand;
                // Set the operator1 property to the value passed in
                this.operator1 = operator1;
                // Set the operator2 property to the value passed in
                this.operator2 = operator2;
                // Set the result property to the value passed in
                this.result = result;
            }

            // Define a method to override the ToString method
            public override string ToString()
            {
                // Return a string with the values of the properties
                return "( " + operand + " , " + operator1 + " , " + operator2 + " , " + result + " )";
            }
        }

        private class fourTupleTable
        {
            // A list to store the four tuples
            private List<fourTuple> table;

            // A property to get the number of tuples in the table
            public int NXQ => table.Count;

            // Constructor to initialize the table
            public fourTupleTable()
            {
                table = new List<fourTuple>();
            }

            // Method to add a new tuple to the table
            public bool add(string operand, string operator1, string operator2, string result)
            {
                table.Add(new fourTuple(operand, operator1, operator2, result));
                return true;
            }

            // Method to update the result of a tuple at a given index
            public bool updateResultbyIndex(int index, string result)
            {
                // Check if the index is valid
                if (index < 0 || index >= table.Count)
                {
                    return false;
                }
                // Update the result of the tuple
                table[index].result = result;
                return true;
            }

            // Method to get the result of a tuple at a given index
            public string getResultbyIndex(int index)
            {
                return table[index].result;
            }

            // Method to get the index of the last item in the table
            public int getLastItemIndex()
            {
                return table.Count - 1;
            }

            // Method to clear the table
            public void clear()
            {
                table.Clear();
            }

            // Method to dump the table to a ListBox
            public void dump(ListBox lb)
            {
                for (int i = 0; i < table.Count; i++)
                {
                    lb.Items.Add((object)("(" + i + ") " + table[i].ToString()));
                }
            }
        }





        private class tempVarTable
        {
            // This list stores the temporary variables
            private List<string> table;

            // Constructor for the tempVarTable class
            public tempVarTable()
            {
                // Initialize the list
                table = new List<string>();
            }

            // This method creates a temporary variable and returns its identifier
            public Identifier createTempVar()
            {
                // Create a string with the format "T" followed by the count of the list + 1
                string text = "T" + (table.Count + 1);
                // Add the string to the list
                table.Add(text);
                // Return a new Identifier object with the string as its name
                return new Identifier(text);
            }

            // This method returns a string with all the temporary variables in the list
            public string dump()
            {
                // Initialize the string
                string text = "";
                // Loop through the list
                foreach (string item in table)
                {
                    // Add each item to the string
                    text = text + item + " ;";
                }
                // Return the string
                return text;
            }

            //This method clears the table
            public void clear()
            {
                //Clears the table
                table.Clear();
            }
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public class Identable
        {
            public void clear() { /* Clear logic */ }
            public void addidentifier(string identifier) { /* Add identifier logic */ }
            public string dump() { return "Identifiers"; /* Dump logic */ }
            public string getValueByName(string name) { return "value"; /* Get value by name logic */ }
            public string getTypeByName(string name) { return "type"; /* Get type by name logic */ }
            public bool ExistIdentifier(string name) { return true; /* Check if identifier exists logic */ }
            public bool updateValueByName(string name, string value) { /* Update value by name logic */ return true; }
            public bool inputTypeByName(string name, string type) { /* Input type by name logic */ return true; }
        }

        public class Constable
        {
            public void clear() { /* Clear logic */ }
            public void add(string constant) { /* Add constant logic */ }
            public string dump() { return "Constants"; /* Dump logic */ }
        }

    }
}
