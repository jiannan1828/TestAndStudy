class Author:
    def __init__(self, name, age, gender):
        self.name = name  # 直接公開屬性
        self.age = age    # 直接公開屬性
        self.gender = gender  # 直接公開屬性

    def introduce(self):
        print(f"Hello, my name is {self.name}, I am {self.age} years old, and my gender is {self.gender}.")