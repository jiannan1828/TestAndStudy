class Author:
    def __init__(self, name, age, gender):
        self.name = name  # �������}�ݩ�
        self.age = age    # �������}�ݩ�
        self.gender = gender  # �������}�ݩ�

    def introduce(self):
        print(f"Hello, my name is {self.name}, I am {self.age} years old, and my gender is {self.gender}.")