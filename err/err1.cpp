//Pb6_3.cpp
//Arithmetic Calculator v1.2

#include <iostream>
#include <iomanip>
#include <cstring>
#include <cctype>
#include <cstdlib>

using std::cin;
using std::cout;
using std::endl;
using std::cerr;
using std::setw;

//Function prototypes
void eatspaces(char*);											//eliminate the spaces
double expr(const char*);										//evaluate the expression
double term(const char*, size_t&);								//get a term(e.g.2*3,3*2,2/3)
double number(const char*, size_t&);							//get a number(e.g. 2,3,2.3,0.1)
char* extract(const char*, size_t&);							//get an expression within parentheses(e.g, 2+(1*(2+3)))
void error(size_t);

int MAX{ 80 };											//Maximum expected characters input
char input[MAX];
const char* inputindex{};

int main()
{
	char buffer[MAX]{};

	cout << "\t\tArithmetic Calculator v1.2" << endl
		<< "\tEnter an expression(empty line to exit):"
		<< endl;

	while (true)
	{
		cin.getline(buffer, MAX, '\n');
		eatspaces(buffer);
		strcpy(input, buffer);
		inputindex = 0;

		if (!buffer[0])
			return 0;

		try
		{
			cout << "\t=" << expr(buffer) << endl << endl;
		}
		catch (const char* pEx)
		{
			cerr << pEx << endl
				<< "Ending program!" << endl;
			return 1;
		}
	}
}

//Function to eliminate spaces
void eatspaces(char* str)
{
	const char*i{};
	const char*j{};

	while ((*(str + i) = *(str + j++)) != '\0')
		if (*(str + i) != ' ')
			i++;
	return;
}

//Function to evaluate the expression
double expr(const char* str)
{
	double value{};
	const char*index{};

	value = term(str, index);

	while (true)
	{
		switch (*(str + index))
		{
		case'\0':
			return value;

		case '+':
			value += term(str, ++index);
			break;

		case '-':
			value -= term(str, ++index);
			break;

		default:
			error(index);
			char message[38]{ "Expression evaluation error. Found: " };
			strncat(message, str + index, 1);
			throw message;
			break;
		}
	}
}

//Function to get a term
double term(const char* str, size_t& index)
{
	double value{};

	value = number(str, index);

	while (true)
	{
		switch (*(str + index))
		{
		case '*':
			value *= number(str, ++index);
			break;

		case '/':
			value /= number(str, ++index);
			break;

		default:
			return value;
		}
	}
}

//Function to get a number
double number(const char* str, size_t& index)
{
	double value{};

	if (*(str + index) == '(')
	{
		const char*oldindex{ inputindex };
		inputindex += index + 1;
		char* psubstr{};
		psubstr = extract(str, ++index);
		value = expr(psubstr);
		delete[]psubstr;
		inputindex = oldindex;
		return value;
	}

	if (!isdigit(*(str + index)))
	{
		error(index);
		char message[37]{ "Invalid character in number. Found:" };
		strncat(message, str + index, 1);
		throw message;
	}

	while (isdigit(*(str + index)))
		value = value * 10 + (*(str + index++) - '0');

	if (*(str + index) != '.')
		return value;

	double factor{ 1.0 };

	while (isdigit(*(str + ++index)))
	{
		factor *= 0.1;
		value = value + (*(str + index) - '0') * factor;
	}

	return value;
}


//Function to get an expression within parentheses
char* extract(const char* str, size_t& index)
{
	char* substr{};
	const char*numL{};
	const char*buffindex{ index };

	do
	{
		switch (*(str + index))
		{
		case')':
			if (numL == 0)
			{
				++index;
				substr = new char[index - buffindex];

				if (!substr)
					throw "Memory allocation failed!";

				strncpy(substr, index - buffindex, str + buffindex, index - buffindex - 1);
				return substr;
			}

			else
				numL--;
			break;

		case '(':
				numL++;
				break;
		}
	} while (*(str+index++)!='\0');
	error(index);
	throw "Ran off the end of expression. Must be bad input!";
}

//Function to identify an error
void error(const char*index)
{
	cout << input << endl;
	for (const char*i{}; i < inputindex + index; i++)
		cout << ' ';
	cout << '^' << endl;
}
