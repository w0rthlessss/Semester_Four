.686           ; Указывает компилятору использовать модель памяти .686 (16-битная)
.model FLAT, C  ; Указывает модель памяти FLAT (плоская) и язык программирования C
INCLUDELIB msvcrt.lib   ; Включает библиотеку msvcrt.lib, содержащую функции времени и другие
time    proto c ,:dword ; Объявляет прототип функции time, которая возвращает время в формате DWORD
srand   proto c ,:dword ; Объявляет прототип функции srand, которая инициализирует генератор случайных чисел
rand    proto c ; Объявляет прототип функции rand, которая генерирует случайное число
.data ; Определяет начало секции данных
    arraySize dd 0 ; Объявляет переменную arraySize типа DWORD и инициализирует ее значением 0

.code ; Определяет начало секции кода
function proc ; Объявляет процедуру с именем function
    ; Настройка стека
    push ebp  ; Сохраняет адрес базового указателя (ebp) в стеке
    mov ebp, esp ; Устанавливает базовый указатель на вершину стека
    push edi
    push esi
    push ebx ; Сохраняет регистры edi, esi и ebx в стеке для их сохранения

    ; Получение аргументов
    mov ebx, [ebp+8] ; arraySize ; Загружает значение arraySize из аргументов функции
    mov esi, [ebp+12] ; initialArray ; Загружает адрес initialArray из аргументов функции

    ; Инициализация генератора случайных чисел
    push 0
    call time   ; Получает текущее время в формате DWORD
    add esp, 4
    push eax
    call srand  ; Устанавливает seed для генератора случайных чисел
    add esp, 4

    ; Цикл для заполнения массива
    xor edi, edi ; i = 0  ; Обнуляет регистр edi (используется как счётчик цикла i)
    loop_start:
        cmp edi, ebx ; Сравнивает i с arraySize
        jge loop_end ; Если i >= arraySize, переход к loop_end

        ; Генерация случайного числа
        call rand     ; Генерирует случайное число
        mov edx, eax  ; Сохраняет результат rand() в edx
        ;mov eax, edx
        cdq          ; Расширяет знаковый бит eax в edx:eax
        mov ecx, 101      ; Делит edx:eax на 101
        idiv ecx      ; Делит edx:eax на 101
        mov eax, edx  ; Перемещает остаток от деления в eax
        sub eax, 50   ; randomNumber = (rand() % 101) - 50

        ; Занесение числа в массив
        mov [esi + edi*4], eax ; Сохраняет случайное число в initialArray[i]

        ; Инкремент счётчика и продолжение цикла
        inc edi       ; Увеличивает i на 1
        jmp loop_start ; Переходит к началу цикла
    loop_end:

    ; Возвращение значения
    mov eax, esi   ; Возвращает адрес initialArray в eax

    ; Восстановление регистров и выход из процедуры
    pop ebx       ; Восстанавливает регистры ebx, esi, edi и ebp
    pop esi
    pop edi
    pop ebp
    ret           ; Возвращает управление вызывающей функции
    function endp ; Окончание процедуры function
; Окончание сборки
END