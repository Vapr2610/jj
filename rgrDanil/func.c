#include"head.h"


char matrix[MATRIX_SIZE][MATRIX_SIZE];

void createKeyMatrix(char *keyString) 
{
    int alpha[26] = {0};
    int k = 0;
    
    // Заполнить пустые ячейки матрицы буквами ключевого слова
    for (int i = 0; i < strlen(keyString); i++) 
    {
        if (keyString[i] >= 'a' && keyString[i] <= 'z') 
        {
            keyString[i] -= 32;
        }
        if (alpha[keyString[i] - 'A'] == 0) 
        {
            matrix[k / 5][k % 5] = keyString[i];
            alpha[keyString[i] - 'A'] = 1;
            k++;
        }
    }

    // Заполнить оставшиеся ячейки матрицы символами алфавита, не встречающимися в ключевом слове
    for (int i = 0; i < 26; i++) {
        if (alpha[i] == 0) 
        {
            if(i + 'A' != 'Q')
            {
            matrix[k / 5][k % 5] = i + 'A';
            k++;
            }
        }
    }

    printf("Ключевая матрица:\n");
    for (int i = 0; i < 5; i++) {
        for (int j = 0; j < 5; j++) {
            printf("%c ", matrix[i][j]);
        }
        printf("\n");
    }
}


// Ищет индексы двух символов в матрице Плейфера
void findIndices(char c1, char c2, int *i1, int *j1, int *i2, int *j2) 
{
    for (int i = 0; i < MATRIX_SIZE; i++) {
        for (int j = 0; j < MATRIX_SIZE; j++) {
            if (matrix[i][j] == c1)     
            {
                *i1 = i;
                *j1 = j;
            }
            if (matrix[i][j] == c2) 
            {
                *i2 = i;
                *j2 = j;
            }
        }
    }
}



