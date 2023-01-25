#define Production 0


#if Production == 1
	#define Log(Text) std::cout << Text << std::endl
#elif defined(Production)
	#define Log(Text) std::cout << "Defined " << Production << std::endl
#else
	#define Log(Text)
#endif

