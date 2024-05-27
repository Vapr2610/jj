#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <time.h>
#define LENGTH  26                       // the cipher key length

void random_string(char * string, size_t length)
{
    char pool[] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    size_t poolsize = strlen(pool);
    size_t index;
    size_t i;

    srand((unsigned)time(NULL));

    for(i = 0; i < length && poolsize > 0; ++i)
    {
        index = rand() % poolsize;       // a random index into the pool
        string[i] = pool[index];         // take that character
        pool[index] = pool[--poolsize];  // replace it with the last pool ...
    }                                    // ... element and shorten the pool
    srand((unsigned)time(NULL));
    string[i] = '\0';
}

int main() {
    FILE *file;
    int num_numbers = 0;
    int num;
    int num_lines = 10; // Произвольное количество строк
    srand((unsigned)time(NULL));
    

    file = fopen("text_file.txt", "w");
    if (file == NULL) {
        printf("Ошибка при открытии файла.\n");
        return 1;
    }


    for (int i = 0; i < num_lines; i++) {
        for (int j = 0; j < rand() % 10 + 1; j++) {
            int a = rand()%10+1;
            if(a%2 == 0)
            {
                int num = rand() % 6+1;
                char c[num + 1];
                random_string(c, num);
                fprintf(file,"%s",c);
            }
            if(a%2 == 1)
            {
                int num = rand() % 100; // Генерируем случайное число от 0 до 99
                fprintf(file, "%d", num);
            }
        }
        fprintf(file, "\n");
    }
    fclose(file);

    file = fopen("text_file.txt", "r");
    if (file == NULL) {
        printf("Ошибка при открытии файла.\n");
        return 1;
    }

    while (fscanf(file, "%d", &num) == 1) {
        num_numbers++;
    }

    fclose(file);

    file = fopen("text_file.txt", "a");
    if (file == NULL) {
        printf("Ошибка при открытии файла.\n");
        return 1;
    }

    fprintf(file, "\n Количество чисел: %d", num_numbers);

    fclose(file);

    printf("Количество чисел в файле успешно определено и добавлено в файл.\n");

    return 0;
}