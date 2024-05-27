#include"head.h" 

// Функция сортировки методом бинарного включения
void binary_insertion_sort(int arr[], int n) {
    int i, loc, j, selected;

    for (i = 1; i < n; ++i) {
        j = i - 1;
        selected = arr[i];

        // находим позицию для вставки
        loc = binary_search(arr, selected, 0, j);

        // передвигаем большие элементы вправо
        while (j >= loc) {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = selected;
    }
}