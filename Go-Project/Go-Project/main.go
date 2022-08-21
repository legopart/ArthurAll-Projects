package main

import (	
	"log"
	"net/http"
	"github.com/gorilla/mux"
	"encoding/json"
)

// Book Struct (Model)
type Book struct {
	ID		string    `json:"id"`
	Isbn	string    `json:"isbn"`
	Title	string    `json:"title"`
	Author	*Author   `json:"author"`
}


// Author Struct
type Author struct {
	Firstname	string	`jsom:"firstname"`
	Lasttname	string	`jsom:"lastname"`
}


var books []Book


// Get All Books
func getBooks(w http.ResponseWriter, r *http.Request){
	w.Header().Set("Content-Type", "application/json")
	json.NewEncoder(w).Encode(books)
}

// Get Single Book
func getBook(w http.ResponseWriter, r *http.Request){
	w.Header().Set("Content-Type", "application/json")
	params := mux.Vars(r)
	for _, item := range books {
		if item.ID == params["id"]{
		json.NewEncoder(w).Encode(item)
		return
		}
	}
	json.NewEncoder(w).Encode(&Book{})
}

// Create a New Book
func createBook(w http.ResponseWriter, r *http.Request){

}

// Update Book
func updateBook(w http.ResponseWriter, r *http.Request){

}

// Delete Book
func deleteBook(w http.ResponseWriter, r *http.Request){

}






func main() {
	//Init Router	//var age int =35
	r := mux.NewRouter()

	// Mock Data - @todo - implement DB
	books = append(books, Book{ID: "1", Isbn: "564564", Title: "Book One", Author: &Author{Firstname: "John", Lasttname: "Doe"}})
	books = append(books, Book{ID: "2", Isbn: "453543", Title: "Book Two", Author: &Author{Firstname: "Steve", Lasttname: "Smith"}})
	books = append(books, Book{ID: "3", Isbn: "346346", Title: "Book Three", Author: &Author{Firstname: "John", Lasttname: "Doe"}})

	//Route Handlers / Endpoints
	r.HandleFunc("/api/books", getBooks).Methods("GET")
	r.HandleFunc("/api/books/{id}", getBook).Methods("GET")
	r.HandleFunc("/api/books", createBook).Methods("POST")
	r.HandleFunc("/api/books/{id}", updateBook).Methods("PUT")
	r.HandleFunc("/api/books/{id}", deleteBook).Methods("DELETE")

	log.Fatal(http.ListenAndServe(":8000", r))
}