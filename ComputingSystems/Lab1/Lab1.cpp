#include <iostream>
#include <string>

using namespace std;

enum options{add = 1, sub, mul, divis, res, quit};

class Operations {
public:
    static int Addition(int first, int second) {
        int res = 0;
        _asm {
            MOV EAX, first
            MOV EBX, second
            ADD EAX, EBX
            MOV res, EAX
        }
        return res;
    }

    static int Subtraction(int first, int second) {
        int res = 0;
        _asm {
            MOV EAX, first
            MOV EBX, second
            SUB EAX, EBX
            MOV res, EAX
        }
        return res;
    }

    static int Multiplication(int first, int second) {
        int res = 0;
        _asm {
            MOV EAX, first
            MOV EBX, second
            IMUL EAX, EBX
            MOV res, EAX
        }
        return res;
    }

    static int Division(int first, int second) {
        int res = 0;
        if (second == 0) {
            cout << "\nError! Division by zero!\n\n";
            return INT_MAX;
        }
        _asm {
            MOV EAX, first
            CDQ
            MOV EBX, second
            IDIV EBX
            MOV res, EAX
        }
        return res;
    }

    static int Remainder(int first, int second) {
        int res = 0;
        if (second == 0) {
            cout << "\nError! Division by zero!\n\n";
            return INT_MAX;
        }
        _asm {
            MOV EAX, first
            CDQ
            MOV EBX, second
            IDIV EBX
            MOV res, EDX
        }
        return res;
    }
};

void Greeting() {
    cout << "Lab #1\n";
    cout << "Group 423\n";
    cout << "Efremov Ivan Andreevich\n";
    cout << "Implemet arithmetic operators using assembler\n";
    cout << '\n';
}

void Options() {
    cout << "[1] - Addition\n";
    cout << "[2] - Subtraction\n";
    cout << "[3] - Multiplication\n";
    cout << "[4] - Divivsion\n";
    cout << "[5] - Remainder\n";
    cout << "[6] - Exit\n\n";
}

int ReadInt(string s) {

    cout << s;
    int tmp = 0;
    while (true) {
        cin >> tmp;
        if (cin.fail()) {
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            cout << "\nUse correct values!\n\n";
            cout << s;
        }
        else {
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            return tmp;
        }
    }
}

int main()
{
    Greeting();
    int result = 0;
    int first = 0, second = 0;
    int option = 0;
    char sign = '\n';

    while (option != options::quit) { 
        Options();
        option = ReadInt(">>");

        if ((option >= options::add && option <= options::res)) {
            cout << "\nEnter first operand\n";
            first = ReadInt(">>");
            cout << "\nEnter second operand\n";
            second = ReadInt(">>");
        }

        switch (option) {
        case options::add:
            result = Operations::Addition(first, second);
            sign = '+';
            break;
        case options::sub:
            result = Operations::Subtraction(first, second);
            sign = '-';
            break;
        case options::mul:
            result = Operations::Multiplication(first, second);
            sign = '*';
            break;
        case options::divis:
            result = Operations::Division(first, second);
            sign = ':';
            break;
        case options::res:
            result = Operations::Remainder(first, second);
            sign = '%';
            break;
        case options::quit:
            cout << "\nProgramm finished it's work!\n";
            exit(EXIT_SUCCESS);
        default:
            cout << "\nThere is no such option in the menu!\n\n";
            continue;
        }

        if (result == INT_MAX) continue;

        cout << '\n' << first << " " << sign << " " << second << " = " << result << "\n\n";

    }
}

