CREATE TABLE "Users"(
    "id" BIGINT NOT NULL,
    "Name" NVARCHAR(255) NOT NULL,
    "Email" NVARCHAR(255) NOT NULL,
    "Password" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "Users" ADD CONSTRAINT "users_id_primary" PRIMARY KEY("id");
CREATE TABLE "Products"(
    "id" BIGINT NOT NULL,
    "Name" BIGINT NOT NULL,
    "Price" BIGINT NOT NULL,
    "ImagePath" NVARCHAR(255) NOT NULL,
    "CategoryID" BIGINT NOT NULL
);
ALTER TABLE
    "Products" ADD CONSTRAINT "products_id_primary" PRIMARY KEY("id");
CREATE TABLE "Purchases"(
    "id" BIGINT NOT NULL,
    "UserID" BIGINT NOT NULL,
    "ProductID" BIGINT NOT NULL,
    "Quantity" BIGINT NOT NULL,
    "PurchaseDate" DATETIME NOT NULL,
    "TotalPrice" BIGINT NOT NULL
);
ALTER TABLE
    "Purchases" ADD CONSTRAINT "purchases_id_primary" PRIMARY KEY("id");
CREATE TABLE "AddToCart"(
    "id" BIGINT NOT NULL,
    "ProductID" BIGINT NOT NULL,
    "UserID" BIGINT NOT NULL
);
ALTER TABLE
    "AddToCart" ADD CONSTRAINT "addtocart_id_primary" PRIMARY KEY("id");
CREATE TABLE "AddToWishlist"(
    "id" BIGINT NOT NULL,
    "ProductID" BIGINT NOT NULL,
    "UserID" BIGINT NOT NULL
);
ALTER TABLE
    "AddToWishlist" ADD CONSTRAINT "addtowishlist_id_primary" PRIMARY KEY("id");
CREATE TABLE "Categories"(
    "id" BIGINT NOT NULL,
    "Name" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "Categories" ADD CONSTRAINT "categories_id_primary" PRIMARY KEY("id");
ALTER TABLE
    "Purchases" ADD CONSTRAINT "purchases_userid_foreign" FOREIGN KEY("UserID") REFERENCES "Users"("id");
ALTER TABLE
    "AddToCart" ADD CONSTRAINT "addtocart_userid_foreign" FOREIGN KEY("UserID") REFERENCES "Users"("id");
ALTER TABLE
    "Products" ADD CONSTRAINT "products_categoryid_foreign" FOREIGN KEY("CategoryID") REFERENCES "Categories"("id");
ALTER TABLE
    "AddToCart" ADD CONSTRAINT "addtocart_productid_foreign" FOREIGN KEY("ProductID") REFERENCES "Products"("id");
ALTER TABLE
    "AddToWishlist" ADD CONSTRAINT "addtowishlist_productid_foreign" FOREIGN KEY("ProductID") REFERENCES "Products"("id");
ALTER TABLE
    "AddToWishlist" ADD CONSTRAINT "addtowishlist_userid_foreign" FOREIGN KEY("UserID") REFERENCES "Users"("id");
ALTER TABLE
    "Purchases" ADD CONSTRAINT "purchases_productid_foreign" FOREIGN KEY("ProductID") REFERENCES "Products"("id");