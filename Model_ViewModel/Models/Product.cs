﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_ViewModel.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public long ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public string ProductImage { get; set; }
        public string ProductShortDesc { get; set; }
        public int ProductCategoryID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int Deleted { get; set; }
        public Category Category { get; set; }
        public Person Person { get; set; }
        public int PersonID { get; set; }
        public int CategoryID { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
        public virtual ICollection<ProductFeatures> ProductFeatures { get; set; }

        public List<Product> GetProduct()
        {
            var ProductList = new List<Product>
            {
                new Product{ProductID=1,ProductName="لپ تاپ 15 اینچی ایسوس مدل VivoBook",ProductPrice=136900,ProductImage="laptop1.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="سری 3 لپ‌تاپ‌های سامسونگ به داشتن ظاهری زیبا، کیفیت ساخت بالا و قیمت مناسب، به یکی از بهترین لپ‌تاپ‌های ارزان قیمت موجود در بازار تبدیل شده‌اند. ظاهر و کیفیت ساخت این لپ‌تاپ‌ها خیلی بهتر از لپ‌تاپ‌های دیگر در این بازه قیمتی است.",ProductCategoryID=1},
                 new Product{ProductID=2,ProductName="لپ تاپ 15 اینچی ایسر مدل Aspire ",ProductPrice=156900,ProductImage="laptop2.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="سری 3 لپ‌تاپ‌های سامسونگ به داشتن ظاهری زیبا، کیفیت ساخت بالا و قیمت مناسب، به یکی از بهترین لپ‌تاپ‌های ارزان قیمت موجود در بازار تبدیل شده‌اند. ظاهر و کیفیت ساخت این لپ‌تاپ‌ها خیلی بهتر از لپ‌تاپ‌های دیگر در این بازه قیمتی است.",ProductCategoryID=1},
                  new Product{ProductID=3,ProductName="لپ تاپ 14 اینچی لنوو مدل Yoga 520 - A1",ProductPrice=1566900,ProductImage="laptop3.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="سری 3 لپ‌تاپ‌های سامسونگ به داشتن ظاهری زیبا، کیفیت ساخت بالا و قیمت مناسب، به یکی از بهترین لپ‌تاپ‌های ارزان قیمت موجود در بازار تبدیل شده‌اند. ظاهر و کیفیت ساخت این لپ‌تاپ‌ها خیلی بهتر از لپ‌تاپ‌های دیگر در این بازه قیمتی است.",ProductCategoryID=1},
                   new Product{ProductID=4,ProductName="لپ تاپ 14 اینچی ایسوس مدل K456UR",ProductPrice=1466900,ProductImage="laptop3.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="سری 3 لپ‌تاپ‌های سامسونگ به داشتن ظاهری زیبا، کیفیت ساخت بالا و قیمت مناسب، به یکی از بهترین لپ‌تاپ‌های ارزان قیمت موجود در بازار تبدیل شده‌اند. ظاهر و کیفیت ساخت این لپ‌تاپ‌ها خیلی بهتر از لپ‌تاپ‌های دیگر در این بازه قیمتی است.",ProductCategoryID=1},
                     new Product{ProductID=5,ProductName="تبلت اپل مدل iPad Pro 10.5 inch WiFi ",ProductPrice=1266900,ProductImage="tablet1.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="تبلت Samsung Galaxy Tab A 8.0 یکی از تبلت های میان رده سامسونگ به حساب می رود که در سال 2019 میلادی رونمایی و روانه بازار شد. مشخصات سخت افزاری و نرم افزاری متوسط و حضور برخی قابلیت های کاربردی، Tab A 8.0 را به گزینه ای مناسب در میان تبلت های میان رده تبدیل کرده است. ",ProductCategoryID=3},
                     new Product{ProductID=6,ProductName="تبلت لنوو مدل Yoga Tab 3 8.0 YT3-850M",ProductPrice=1266400,ProductImage="tablet2.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="تبلت Samsung Galaxy Tab A 8.0 یکی از تبلت های میان رده سامسونگ به حساب می رود که در سال 2019 میلادی رونمایی و روانه بازار شد. مشخصات سخت افزاری و نرم افزاری متوسط و حضور برخی قابلیت های کاربردی، Tab A 8.0 را به گزینه ای مناسب در میان تبلت های میان رده تبدیل کرده است. ",ProductCategoryID=3},
                      new Product{ProductID=7,ProductName="گوشی موبایل ایسوس مدل Zenfone Zoom",ProductPrice=1466400,ProductImage="mobile1.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="در سال 2021، سری گوشی‌های Galaxy S زودتر از هر سال روانه بازار شد. این سری این بار با خود ویژگی‌های جدیدی را هم به همراه داشت. گوشی موبایل Galaxy S21 Ultra جای همه کم‌وکاستی‌های نسل خود را پر کرده است. صفحه‌نمایشی با نرخ به‌روزرسانی 120هرتز بیشتر از هر چیز کنایه‌ای پرمعنا به اپل است",ProductCategoryID=2},
                       new Product{ProductID=8,ProductName="گوشی موبایل اپل مدل iPhone 8 ظرفیت 64 ",ProductPrice=112466400,ProductImage="mobile2.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="در سال 2021، سری گوشی‌های Galaxy S زودتر از هر سال روانه بازار شد. این سری این بار با خود ویژگی‌های جدیدی را هم به همراه داشت. گوشی موبایل Galaxy S21 Ultra جای همه کم‌وکاستی‌های نسل خود را پر کرده است. صفحه‌نمایشی با نرخ به‌روزرسانی 120هرتز بیشتر از هر چیز کنایه‌ای پرمعنا به اپل است",ProductCategoryID=2},
                        new Product{ProductID=9,ProductName="گوشی موبایل سامسونگ مدل Galaxy J7",ProductPrice=134466400,ProductImage="mobile3.jpg",ProductDesc="استفاده از تراشه‌ی اختصاصی سامسونگ، A7‌ را تا‌حد زیادی به معیار‌های موردتوجه کاربران هنگام خرید، نزدیک کرده است. این تراشه‌ یک پله ضعیف‌تر از تراشه‌ی‌ S7‌ است؛ در‌عوض به‌ A7‌، قدرت نمایش باشکوه هرگونه عملیات موردنظرتان را می‌دهد. پردازنده‌ی مرکزی هشت‌هسته‌ای همراه سه گیگابایت رم، همه‌ی برنامه‌ها و بازی‌های موجود در فروشگاه را به‌راحتی اجرا می‌کند. شاید نهایتا با این گوشی در اجرای بازی‌هایی با گرافیک بالا کمی لگ داشته باشید.",ProductShortDesc="در سال 2021، سری گوشی‌های Galaxy S زودتر از هر سال روانه بازار شد. این سری این بار با خود ویژگی‌های جدیدی را هم به همراه داشت. گوشی موبایل Galaxy S21 Ultra جای همه کم‌وکاستی‌های نسل خود را پر کرده است. صفحه‌نمایشی با نرخ به‌روزرسانی 120هرتز بیشتر از هر چیز کنایه‌ای پرمعنا به اپل است",ProductCategoryID=2},
            };

            return ProductList;
        }
    }
}
