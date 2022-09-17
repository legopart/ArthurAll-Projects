#pragma once
#include <iostream>

template<typename T>
class Array2
{
private:
	T* itemArray;
	int arrayLength;
	int count; //count
	void resize();
	bool needToReSize();
	bool needToReSize(int index);
public:
	Array2(int length);
	Array2();
	bool contains(T item);
	int indexOf(T item);
	int lastIndexOf(T item);
	T get(int index);
	int size();
	T add(T item);
	int set(int index, T item);
	T remove(int index);
	T removeItem(T item);
	void print();
};



template<typename  T>
inline void Array2<T>::resize()
{
	int* newArray = new int[arrayLength * 2];
	for (int i = 0; i < arrayLength; ++i)
		newArray[i] = itemArray[i];
	//delete(itemArray);
	itemArray = newArray;
	arrayLength *= 2;
}

template<typename  T>
bool Array2<T>::needToReSize()
{
	return arrayLength == count;
}

template<typename T>
bool Array2<T>::needToReSize(int index)
{
	return index >= count;
}

template<typename T>
inline Array2<T>::Array2(int length)
{
	count = 0;
	arrayLength = length;
	itemArray = new T[arrayLength];
}

template<typename T>
inline Array2<T>::Array2()
{
	Array2(5);
}

template<typename T>
bool Array2<T>::contains(T item)
{
	return indexOf(item) != -1;
}

template<typename T>
int Array2<T>::indexOf(T item)
{
	for (int i = 0; i < count; ++i) if (itemArray[i] == item) return i;
	return -1;
}

template<typename T>
int Array2<T>::lastIndexOf(T item)
{
	return itemArray[indexOf(item)];
}

template<typename T>
T Array2<T>::get(int index)
{
	return itemArray[index];
}

template<typename T>
int Array2<T>::size()
{
	return count;
}

template<typename T>
T Array2<T>::add(T item)
{
	if (needToReSize()) resize();
	itemArray[count] = item;
	count++;
	return item;
}

template<typename T>
int Array2<T>::set(int index, T item)
{
	if (needToReSize(index)) throw 0;
	itemArray[index] = item;
	return item;
}

template<typename T>
T Array2<T>::remove(int index)
{
	int item = itemArray[index];
	if (needToReSize(index)) throw 0;
	for (int i = index; i < count; i++)
		itemArray[i] = itemArray[i + 1];
	count--;
	return item;
}

template<typename T>
T Array2<T>::removeItem(T item)
{
	return remove(indexOf(item));
}

template<typename T>
void Array2<T>::print()
{
	for (int i = 0; i < count; ++i)
		std::cout << itemArray[i] << ", ";
	std::cout << "\n";
}
