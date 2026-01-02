document.addEventListener("DOMContentLoaded", function () {

    const books = [
        {
            title: "Clean Code",
            type: "Programming",
            status: "Available",
            img: "book1.jpg"
        },
        {
            title: "Atomic Habits",
            type: "Self Help",
            status: "Not Available",
            img: "book2.jpg"
        },
        {
            title: "Java Basics",
            type: "Academic",
            status: "Available",
            img: "book3.jpg"
        }
    ];

    const container = document.getElementById("bookList");

    books.forEach(book => {
        container.innerHTML += `
        <div class="col-xl-3 col-lg-4 col-md-6">
            <div class="card book-card h-100 border-0 shadow-sm">

                <div class="position-relative">
                    <div class="ratio ratio-1x1">
                        <img src="/images/${book.img}"
                             class="card-img-top object-fit-cover"
                             alt="${book.title}">
                    </div>

                    <span class="badge ${book.status === "Available" ? "bg-success" : "bg-danger"}
                          position-absolute top-0 end-0 m-2">
                        ${book.status}
                    </span>
                </div>

                <div class="card-body text-center">
                    <h6 class="fw-semibold">${book.title}</h6>
                    <p class="text-muted small">${book.type}</p>

                    <a href="#" class="btn btn-outline-primary btn-sm w-100">
                        View Details
                    </a>
                </div>
            </div>
        </div>
        `;
    });

});
// JavaScript source code
