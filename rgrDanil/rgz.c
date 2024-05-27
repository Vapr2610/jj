#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include"head.h"



int main(int argc, char *argv[])
{
    if (argc != 4) {
        printf("Указаны не все файлы");
        exit(EXIT_FAILURE);
    }

    // Открытие файлов
    FILE *keyFile = fopen(argv[1], "r");
    FILE *phraseFile = fopen(argv[2], "r");
    FILE *codeFile = fopen(argv[3], "r");
    if (keyFile == NULL || phraseFile == NULL || codeFile == NULL) {
        printf("Ошибка открытия файлов\n");
        return 1;
    }
    // Чтение ключа, фразы и шифра
    //Выделение памяти под текст ключа
    int ikey; fseek(keyFile, 0, ikey);
    char* key = malloc(ikey+1);
    //Выделение памяти под текст фразы
    int iphrase; fseek(phraseFile, 0, iphrase);
    char* phrase = malloc(ikey+1);
    //Выделение памяти под зашифрованный текст
    int icode; fseek(codeFile, 0, icode);
    char* code = malloc(ikey+1);

    char ch;
    int i = 0;
    while (!feof(keyFile))//проверка конца файла
    {
        ch = getc(keyFile);//читает и возвращает символ из файла
        key[i++] = ch;
    }//считываем файл ключа в переменную key
    key[i-1] = '\0';

    i = 0;
    while (!feof(phraseFile))//проверка конца файла
    {
        ch = getc(phraseFile);//читает и возвращает символ из файла
        phrase[i++] = ch;
    }//считываем файл фразы в переменную phrase
    phrase[i-1] = '\0';

    i = 0;
    while (!feof(codeFile))//проверка конца файла
    {
        ch = getc(codeFile);//читает и возвращает символ из файла
        code[i++] = ch;
    }//считываем файл фразы в переменную code
    code[i-1] = '\0';

    printf("Шифровка или дешифровка? (e/d) ");
    char choice;
    scanf("%c", &choice);
    if (choice == 'e')
    {
        printf("Ключ: %s\n", key);
        printf("Текст до шифрования: %s\n", phrase);
        
        // Шифрование фразы
        char *ciphertext = PlayKey(phrase, key);

        // Вывод зашифрованного текста на экран
        printf("Зашифрованный текст: %s\n", ciphertext);

        // Запись в файл encod.txt
        FILE* encodFile = fopen("enc.txt", "w");
        fputs(ciphertext, encodFile);
        printf("Файл enc.txt создан");

        // Закрытие файлов
        fclose(keyFile);
        fclose(phraseFile);
        fclose(encodFile);
    }
    else if (choice == 'd')
    {
         printf("Ключ: %s\n", key);
        printf("Шифр до дешифрования: %s\n", code);
        
        // Дешифрование шифра
        char *ciphertext = DePlayKey(code, key);

        // Вывод дешифрованного текста на экран
        printf("Текст: %s\n", ciphertext);

        // Запись в файл decod.txt
        FILE* decodFile = fopen("dec.txt", "w");
        fputs(ciphertext, decodFile);
        printf("Файл dec.txt создан");

        // Закрытие файлов
        fclose(keyFile);
        fclose(codeFile);
        fclose(decodFile);
    }
    else
        printf("Error\n");
    free(key);
    free(phrase);
    free(code);
}