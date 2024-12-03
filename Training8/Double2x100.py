import random
import json

random_array = []

for i in range(2):  
    row = []  

    for j in range(100):  
        row.append(random.uniform(0, 100))  

    random_array.append(row)  

print(json.dumps(random_array))  # 直接輸出 JSON 字符串