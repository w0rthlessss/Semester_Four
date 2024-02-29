#include <iostream>

using namespace std;

enum class MENU { check = 1, exit = 2 };

template<typename T>
T checkInput() {
	T userInput{};
	while (!(cin >> userInput)) {
		cin.clear();
		cin.ignore(INT_MAX, '\n');
		cout << "Введены некорректные данные. Попробуйте снова." << endl;
	}
	cin.ignore(INT_MAX, '\n');
	return userInput;
}

int GetUnsInt() {
	int input = checkInput<int>();
	if (input < 0) {
		cout << "Взято значение по модулю." << endl;
		input = abs(input);
	}
	return input;
}

bool numIsPrime(unsigned int number) {
	int isNumberDivisible = 0;
	bool prime = true;
	for (unsigned int i = 2; i <= sqrt(number); i++) {
		const int denom = i;
		_asm {
			XOR EDX, EDX
			MOV EAX, number
			DIV denom
			CMP EDX, 1
			JGE L01
			MOV isNumberDivisible, 1
			L01:
		}
		if (isNumberDivisible) {
			prime = false;
			return prime;
		}
	}
	if (number <= 1)
		prime = false;
	return prime;
}

//bool numIsPrime(unsigned int number) {
//	int isNumberDivisible = 0;
//	bool prime = true;
//		_asm {
//			CMP number, 1
//			JG L01
//			MOV isNumberDivisible, 1
//			JMP for_finish
//
//			L01:
//			CMP number,2
//			JG for_start
//			JMP for_finish
//
//			for_start:
//			MOV EBX, 2
//			for_loop:
//				XOR EDX, EDX
//				MOV EAX, number
//				DIV EBX
//				CMP EDX, 0
//				JNE L02
//				MOV isNumberDivisible, 1
//				JMP for_finish
//				L02:
//			ADD EBX, 1
//			CMP EBX, number
//			JNE for_loop
//			for_finish:
//		}
//		if (isNumberDivisible)
//			prime = false;
//	return prime;
//}


int main() {
	setlocale(LC_CTYPE, "Russian");
	unsigned int number;
	cout << "Лабораторная работа №2 по ВССиТ" << endl;
	cout << "Выполнено студентами 423 группы Сафаровым Рустамом, Агишевым Даниилом, Ефремовым Иваном" << endl;
	while (true) {
		cout << "==============================================" << endl;	
		cout << "Выберите действие: " << endl;
		cout << "1 - проверка простоты числа" << endl;
		cout << "2 - завершение работы" << endl;
		MENU choice = static_cast<MENU>(checkInput<int>());
		switch (choice) {
		case MENU::check:
			cout << "Введите число для выполнения проверки: ";
			number = GetUnsInt();
			if (numIsPrime(number)) {
				cout << endl << "Число " << number << " является простым." << endl << endl;
			}
			else {
				cout << endl << "Число " << number << " не является простым." << endl << endl;
			}
			break;
		case MENU::exit:
			cout << "Работа программы была завершена пользователем." << endl;
			return 0;
			break;
		default:
			cout << "Введены некорректные данные. Попробуйте снова." << endl;
		}

	}
}
