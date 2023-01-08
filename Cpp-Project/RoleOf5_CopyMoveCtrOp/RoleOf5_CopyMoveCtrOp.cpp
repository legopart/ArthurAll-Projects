#include <iostream>
#include <memory>
#include <vector>
#include <algorithm>
#include <numeric>
using namespace std;


class Widget
{

private:
	int mX;
	const size_t numElements = 1'000'000;	//first set size
	int* mPtr;
public:
	Widget(int x) : mPtr{ new int[numElements] }, mX{ x }
	{}


	void copyCtrOp(const Widget& other)	// = &
	{
		mX = other.mX;
		memcpy(mPtr, other.mPtr, sizeof(int) * numElements);
	}

	Widget(const Widget& other) : mPtr{ new int[numElements] }//, mX { other.mx } 	//important to start as the constructure
	{
		copyCtrOp(other);
		cout << "copied()" << endl;
	}

	Widget& operator=(const Widget& other)
	{
		if (this != &other) copyCtrOp(other);
		cout << "copied=" << endl;
		return *this;
	}


	//move
	void moveCtrOp(Widget&& other)	// const& &&
	{
		mX = other.mX;
		//other.x = NULL;	//x not a resource, not movable, cant delete
		mPtr = other.mPtr;
		other.mPtr = nullptr;
	}

	Widget(Widget&& other) noexcept //: mPtr{ other.mPtr }, mX{ other.mX }
	{
		moveCtrOp(move(other));

		cout << "moved()" << endl;
	}

	Widget& operator=(Widget&& other) noexcept
	{
		if (this != &other) moveCtrOp(move(other));
		cout << "moved=" << endl;
		return *this;
	}



	bool operator<(const Widget& other)
	{
		return this->mX < other.mX;
		//return std::less<const Widget*>()(this, &other);
	}

	~Widget()
	{
		delete[] mPtr;
	}
public:
	friend ostream& operator<<(ostream& os, const Widget& wdg);
};



ostream& operator<<(ostream& os, const Widget& wdg)
{
	os << wdg.mX;
	return os;
}

int main()
{
	vector<Widget> v = { 6, 3, 1, 4, 5 };
	std::sort(v.begin(), v.end());


	cout << endl;
	cout << "ordered vector" << endl;
	for (const Widget& wdg : v)
		cout << wdg << " ";
	cout << endl;


	Widget a1(20);
	Widget a2(30);
	a1 = a2;					//copied =
	Widget a3(a2);				//copied ()
	a1 = move(a2);		//move =
	Widget a4(move(a3));	// move ()
		//moved a2, a3 is unuseable (for array)
}