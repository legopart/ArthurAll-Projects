//#pragma once
#include <iostream>
using std::string, std::to_string, std::cout;
class Array1 {
private:
    int* itemArray;
    int arrayLength;
    int count; //count
    void resize() {
        int* newArray = new int[arrayLength * 2];
        for (int i = 0; i < arrayLength; ++i)
            newArray[i] = itemArray[i];
        //delete(itemArray);
        itemArray = newArray;
        arrayLength *= 2;
    };
    bool needToReSize() { return arrayLength == count; };
    bool needToReSize(int index) { return index >= count; };
public:
    Array1(int length) {
        count = 0;
        arrayLength = length;
        itemArray = new int[arrayLength];
    }
    Array1() { Array1(5); }
    bool contains(int item) { return indexOf(item) != -1; };
    int indexOf(int item) {
        for (int i{}; i < count; ++i) if (itemArray[i] == item) return i;
        return -1;
    };
    int lastIndexOf(int item) { return itemArray[indexOf(item)]; };
    int get(int index) { return itemArray[index]; };
    int size() const { return count; };
    int add(int item) {
        if (needToReSize()) resize();
        itemArray[count] = item;
        count++;
        return item;
    }
    int set(int index, int item) {
        if (needToReSize(index)) throw 0;
        itemArray[index] = item;
        return item;
    };
    int remove(int index) {
        int item = itemArray[index];
        if (needToReSize(index)) throw 0;
        for (int i = index; i < count; i++) itemArray[i] = itemArray[i + 1];
        count--;
        return item;
    };
    int removeItem(int item) { return remove(indexOf(item)); };
    void print() const {
        for (int i = 0; i < count; ++i) cout << itemArray[i] << ", ";
        cout << "\n";
    }
};
