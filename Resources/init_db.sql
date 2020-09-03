create database purchaselist;
use purchaselist;

drop table if exists purchase_has_product;
drop table if exists purchase;
drop table if exists purchase_list_has_product;
drop table if exists purchase_list;
drop table if exists product;
drop table if exists user;

create table user (
	id int not null auto_increment,
    name varchar(255) not null,
    login varchar(100) not null,
    password varchar(255) not null,
    primary key (id)
);

create table product (
	id int not null auto_increment,
    name varchar(255) not null,
    created_at timestamp not null default now(),
    modified_at timestamp not null default now(),
    created_by int not null,
    description varchar(255) null,
    estimated_price float null,
    primary key (id),
    foreign key (created_by) references user(id)
);

create table purchase_list(
	id int not null auto_increment,
    name varchar(255) not null,
    created_at timestamp not null default now(),
    modified_at timestamp not null default now(),
    created_by int not null,
    primary key (id),
    foreign key (created_by) references user(id)
);

create table purchase_list_has_product (
	purchase_list_id int not null,
    product_id int not null,
    quantity int not null default 1,
    primary key (purchase_list_id, product_id),
    foreign key (purchase_list_id) references purchase_list(id),
    foreign key (product_id) references product(id)
);

create table purchase (
	id int not null auto_increment,
    name varchar(255) null,
    created_at timestamp not null default now(),
    created_by int not null,
    purchase_list_id int null,
    primary key (id),
    foreign key (created_by) references user(id),
    foreign key (purchase_list_id) references purchase_list(id)
);

create table purchase_has_product (
	purchase_id int not null,
    product_id int not null,
    price float null,
    primary key (purchase_id, product_id),
    foreign key (purchase_id) references purchase(id),
    foreign key (product_id) references product(id)
);

