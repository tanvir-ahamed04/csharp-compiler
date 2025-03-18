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
        private Identable identable;
        private Constable constable;
        private twoTuple presentInput;

        public Form1()
        {
            InitializeComponent();
            // Initialize input_program and text
            input_program = string.Empty;
            text = string.Empty;

            identable = new Identable();
            constable = new Constable();
            presentInput = new twoTuple(string.Empty, string.Empty);
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
                if (c == '\n')
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
                listBox2.Items.Add(new twoTuple($"Keyword error (Line {line_number}, Char {char_position})", text));
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


        //private bool parseVarExplainSection()
        //{
        //    print("[Syntax] Derivation: <Variable Declaration Part> → <Variable Declaration> <Identifier List>");

        //    if (match("variable description"))
        //    {
        //        if (parseIdentifierList())
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            print("Error: Failed to parse identifier list.");
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        print("Error: Failed to match variable description.");
        //        return false;
        //    }
        //}


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

        //private bool parseWhileStatement()
        //{
        //    print("[Syntax]Derivation: <Loop Statement> → while (<Condition>) do <Nested Statement>");

        //    if (match("keyword while"))
        //    {
        //        if (match("left bracket"))
        //        {
        //            if (parseLogicExpression())
        //            {
        //                if (match("right bracket"))
        //                {
        //                    if (match("keyword do"))
        //                    {
        //                        if (parseNestedStatement())
        //                        {
        //                            return true;
        //                        }
        //                        else
        //                        {
        //                            print("Error: Failed to parse nested statement.");
        //                            return false;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        print("Error: Failed to match keyword do.");
        //                        return false;
        //                    }
        //                }
        //                else
        //                {
        //                    print("Error: Failed to match right bracket.");
        //                    return false;
        //                }
        //            }
        //            else
        //            {
        //                print("Error: Failed to parse logic expression.");
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            print("Error: Failed to match left bracket.");
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        print("Error: Failed to match keyword while.");
        //        return false;
        //    }
        //}

        //private bool ParseNestedStatement()
        //{
        //    // If the present input is an identifier, keyword if, or keyword while
        //    if (presentInput.type == "identifier" || presentInput.type == "keyword if" || presentInput.type == "keyword while")
        //    {
        //        // Print the derivation of the nested statement
        //        print("[Syntax]Derivation: <Nested Statement> → <Statement>");
        //        parseStatement();
        //        return true;
        //    }
        //    else if (presentInput.type == "keyword begin")
        //    {
        //        print("[Syntax]Derivation: <Nested Statement> → <Compound Statement>");
        //        parseCompoundStatement();
        //        return true;
        //    }
        //    return false;
        //}
        //private bool ParseExpressionFactor()
        //{
        //    if (presentInput.type == "identifier")
        //    {
        //        print("[Syntax]Derivation: <Factor> → <Identifier>");
        //        match("identifier");
        //        return true;
        //    }
        //    else if (presentInput.type == "constant")
        //    {
        //        print("[Syntax]Derivation: <Factor> → <Constant>");
        //        match("constant");
        //        return true;
        //    }
        //    else if (presentInput.type == "left bracket")
        //    {
        //        print("[Syntax]Derivation: <Factor> → (<Expression>)");
        //        match("left bracket");
        //        parseExpression();
        //        match("right bracket");
        //        return true;
        //    }
        //    return false;
        //}




        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Items.Add("Mid-Code Output:  ");

            listBox2.Items.Add("");
            listBox2.Items.Add(new twoTuple($"Compiler Author", "Tanvir Ahamed"));
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (e.Index < 0) return;

            string? itemText = listBox1.Items[e.Index]?.ToString();

            if (itemText == null) return;

            Color itemColor = Color.White; // Default color
            if (itemText.Contains("identifier"))
            {
                itemColor = Color.Blue; 
            }
            else if (itemText.Contains("constant"))
            {
                itemColor = Color.Orange; 
            }
            else if (itemText.Contains("keyword"))
            {
                itemColor = Color.Green; 
            }
            else if (itemText.Contains("separator"))
            {
                itemColor = Color.Purple;
            }
            else if (itemText.Contains("operator"))
            {
                itemColor = Color.Brown; 
            }
            else if (itemText.Contains("error"))
            {
                itemColor = Color.Red; // Error color
            }

            e.DrawBackground();

            using (Brush brush = new SolidBrush(itemColor))
            {

                if (e.Font != null)
                {

                    e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }

        private void listBox2_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (e.Index < 0) return;

            string? itemText = listBox2.Items[e.Index]?.ToString();

            if (itemText == null) return;

            Color itemColor = Color.White; // Default color
            if (itemText.Contains("identifier"))
            {
                itemColor = Color.Blue; 
            }
            else if (itemText.Contains("constant"))
            {
                itemColor = Color.Orange; 
            }
            else if (itemText.Contains("keyword"))
            {
                itemColor = Color.Green;
            }
            else if (itemText.Contains("separator"))
            {
                itemColor = Color.Purple; 
            }
            else if (itemText.Contains("operator"))
            {
                itemColor = Color.Brown; 
            }
            else if (itemText.Contains("error"))
            {
                itemColor = Color.Red; 
            }

            e.DrawBackground();

            using (Brush brush = new SolidBrush(itemColor))
            {

                if (e.Font != null)
                {

                    e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }
    }


    public class Identable
    {
        public void clear() { /* Clear logic */ }
        public void addidentifier(string identifier) { /* Add identifier logic */ }
        public string dump() { return "Identifiers"; /* Dump logic */ }
    }

    public class Constable
    {
        public void clear() { /* Clear logic */ }
        public void add(string constant) { /* Add constant logic */ }
        public string dump() { return "Constants"; /* Dump logic */ }
    }

}
