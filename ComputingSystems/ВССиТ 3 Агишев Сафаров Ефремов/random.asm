.686           ; ��������� ����������� ������������ ������ ������ .686 (16-������)
.model FLAT, C  ; ��������� ������ ������ FLAT (�������) � ���� ���������������� C
INCLUDELIB msvcrt.lib   ; �������� ���������� msvcrt.lib, ���������� ������� ������� � ������
time    proto c ,:dword ; ��������� �������� ������� time, ������� ���������� ����� � ������� DWORD
srand   proto c ,:dword ; ��������� �������� ������� srand, ������� �������������� ��������� ��������� �����
rand    proto c ; ��������� �������� ������� rand, ������� ���������� ��������� �����
.data ; ���������� ������ ������ ������
    arraySize dd 0 ; ��������� ���������� arraySize ���� DWORD � �������������� �� ��������� 0

.code ; ���������� ������ ������ ����
function proc ; ��������� ��������� � ������ function
    ; ��������� �����
    push ebp  ; ��������� ����� �������� ��������� (ebp) � �����
    mov ebp, esp ; ������������� ������� ��������� �� ������� �����
    push edi
    push esi
    push ebx ; ��������� �������� edi, esi � ebx � ����� ��� �� ����������

    ; ��������� ����������
    mov ebx, [ebp+8] ; arraySize ; ��������� �������� arraySize �� ���������� �������
    mov esi, [ebp+12] ; initialArray ; ��������� ����� initialArray �� ���������� �������

    ; ������������� ���������� ��������� �����
    push 0
    call time   ; �������� ������� ����� � ������� DWORD
    add esp, 4
    push eax
    call srand  ; ������������� seed ��� ���������� ��������� �����
    add esp, 4

    ; ���� ��� ���������� �������
    xor edi, edi ; i = 0  ; �������� ������� edi (������������ ��� ������� ����� i)
    loop_start:
        cmp edi, ebx ; ���������� i � arraySize
        jge loop_end ; ���� i >= arraySize, ������� � loop_end

        ; ��������� ���������� �����
        call rand     ; ���������� ��������� �����
        mov edx, eax  ; ��������� ��������� rand() � edx
        ;mov eax, edx
        cdq          ; ��������� �������� ��� eax � edx:eax
        mov ecx, 101      ; ����� edx:eax �� 101
        idiv ecx      ; ����� edx:eax �� 101
        mov eax, edx  ; ���������� ������� �� ������� � eax
        sub eax, 50   ; randomNumber = (rand() % 101) - 50

        ; ��������� ����� � ������
        mov [esi + edi*4], eax ; ��������� ��������� ����� � initialArray[i]

        ; ��������� �������� � ����������� �����
        inc edi       ; ����������� i �� 1
        jmp loop_start ; ��������� � ������ �����
    loop_end:

    ; ����������� ��������
    mov eax, esi   ; ���������� ����� initialArray � eax

    ; �������������� ��������� � ����� �� ���������
    pop ebx       ; ��������������� �������� ebx, esi, edi � ebp
    pop esi
    pop edi
    pop ebp
    ret           ; ���������� ���������� ���������� �������
    function endp ; ��������� ��������� function
; ��������� ������
END