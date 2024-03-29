// file main.cpp
#include <iostream>
#include <ctime>
#include <vector>
#include <Windows.h>
using namespace std;
extern "C" int MODIFY_ARRAY(int*, int);
extern "C" int* function(int, int*);


#include <iostream>
#include <cstdlib>
#include <ctime>

// Function prototype
//void function(int arraySize, int* initialArray);
//
//void function(int arraySize, int* initialArray) {
//	srand(time(0));
//	for (int i = 0; i < arraySize; ++i) {
//		int randomNumber = (std::rand()%101)-50; 
//		initialArray[i] = randomNumber;
//	}
//}



int main() {
	setlocale(LC_CTYPE, "Russian");

	srand((unsigned int)time(NULL));

	int* initialArray = nullptr;
	int i = 0, numberOfReplaces = 0, size = 0;

	cout << "Лабораторная работа №3 по ВССиТ" << endl;
	cout << "Выполнено студентами 423 группы Сафаровым Рустамом, Агишевым Даниилом, Ефремовым Иваном" << endl;

	cout << "Введите размер массива: ";
	cin >> size;

	initialArray = new int[size];
	initialArray = function(size, initialArray);
	cout << "Исходный массив: ";

	for (i = 0; i < size; i++) {
		cout << initialArray[i] << " ";
	}
	cout << endl;

	numberOfReplaces = MODIFY_ARRAY(initialArray, size);

	cout << endl << "Итоговый массив: ";
	for (i = 0; i < size; i++) {
		cout << initialArray[i] << " ";
	}
	cout << endl;

	cout << "Количество преобразованных элементов: " << numberOfReplaces << endl;

	initialArray = nullptr;
	return 0;
}