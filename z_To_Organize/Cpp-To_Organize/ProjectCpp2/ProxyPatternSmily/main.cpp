#include "Bitmap.h"
#include "BitmapProxy.h"
//#include <stdexcept>
#include <exception>
#include <stdexcept>
#include <iostream>

int main() {
	//Image* img = new Bitmap{ "banner.txt" };
	Image* img = new BitmapProxy{ "banner.txt" };
	try {
		img->Load();
		img->Display();
		img->Load("Smiley.txt");
		img->Display();
		
	}
	catch(std::exception e) {
		std::cout << "exeption: " << e.what() << "\n";

	}
	delete img;
}
