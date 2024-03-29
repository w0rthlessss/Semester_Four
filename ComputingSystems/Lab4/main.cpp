#include <iostream>
using namespace std;

int* a;
int* b;

int FirstFunction(int arg) {
	int res = 0;
	int eax = arg;
	eax -= 32;
	eax *= 5;
	int ecx = 9;
	eax /= ecx;
	res = eax;
	return res;
}

int SecondFunction(int argFirst, int argSecond){
	int eax = argFirst;
	eax += argSecond;
	argFirst = eax;
	eax = argFirst;
	return argFirst;
}

void ThirdFunction() {
	int argFirst = 100;
	*a = FirstFunction(argFirst);
	argFirst = 16;
	int argSecond = 8;
	*b = SecondFunction(argFirst, argSecond);
	return;
}

int main() {
	a = new int();
	b = new int();
	ThirdFunction();
	cout << "Register [a] has value of: " << *a;
	cout << endl;
	cout << "Register [b] has value of: " << *b;
	delete a;
	delete b;
	return 0;
}