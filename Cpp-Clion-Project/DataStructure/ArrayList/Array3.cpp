//TheCirno

template<typename T ,size_t/*int*/ S>
class Array3
{
private:
    T m_Data[S]{};
public:
    Array3() { }
    ~Array3() { delete[](m_Data); }
    constexpr size_t Size() const { return S; }
    T& operator[](size_t index) { //allow data[2] = 2 .
        //if (!(index < 5)) { __debugbreak(); }
        return m_Data[index];
    }
    const T& operator[](size_t index) const { return m_Data[index]; } // call reference allow
    T* Data()  { return m_Data;  }
    const T* Data() const { return m_Data; }

    //for(auto& a : array3 ) להשלים Iterator
    //fill
    //swap
};