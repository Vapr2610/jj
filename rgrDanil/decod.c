#include"head.h"

char* DePlayKey(char *plaintext1, char *key) 
{
    char* plaintext = malloc(strlen(plaintext1));
    int j = 0;
    for (int i = 0; plaintext1[i] != '\0'; i++) {
        if (plaintext1[i] != ' ') {
            plaintext[j++] = plaintext1[i];
        }
    }
    plaintext[j] = '\0';
    //printf("\n%s\n", plaintext);

    j = 0;
    char keyString[100];
    for (int i = 0; key[i] != '\0'; i++) {
        if (key[i] != ' ') {
            keyString[j++] = key[i];
        }
    }
    keyString[j] = '\0';
    //printf("\n%s\n", keyString);

    size_t len = strlen(plaintext); //printf("%d\n",len);
    char *ciphertext = malloc(len + 1);       

    createKeyMatrix(keyString);
    int f = 0;
     // Дешифровка
    for (int i = 0, h = 0; i < len; i += 2, h += 2) {
        
        char c1 = plaintext[i]; 
        char c2 = plaintext[i + 1];

        int i1, j1, i2, j2;
        findIndices(c1, c2, &i1, &j1, &i2, &j2);

        
        // Если символы находятся в одном столбце
        if (j1 == j2) {
            ciphertext[h] = matrix[(i1 - 1) % MATRIX_SIZE][j1];
            ciphertext[h + 1] = matrix[(i2 - 1) % MATRIX_SIZE][j2];
        }
        // Если символы находятся в одной строке
        else if (i1 == i2) {
            ciphertext[h] = matrix[i1][(j1 - 1) % MATRIX_SIZE];
            ciphertext[h + 1] = matrix[i2][(j2 - 1) % MATRIX_SIZE];
        }
        // Если находятся в разных столбцах и разных строках
        else if(i1 != i2 && j1 != j2){
            ciphertext[h] = matrix[i1][j2];
            ciphertext[h + 1] = matrix[i2][j1];
        }
        if(ciphertext[h + 1] == 'X')//Если два символа совпадают
        {
            //ciphertext[h + 1] = ciphertext[h];
            h--;
        }
        //printf("%c%c ", ciphertext[h], ciphertext[h + 1]);
    }

    ciphertext[len] = '\0';
    //printf("\n");
    free(plaintext);

    return ciphertext;
}
