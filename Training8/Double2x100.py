import random
import json

# 初始化一個空的陣列，用來儲存結果
random_array = []

# 使用迴圈來生成 2 行，每行 100 個隨機數
for i in range(2):  # 兩行
    row = []  # 每行初始化為一個空的列表
    for j in range(100):  # 每行 100 個隨機數
        row.append(random.uniform(0, 100))  # 將隨機數添加到當前行
    random_array.append(row)  # 將整行添加到陣列中

# 返回 JSON 格式的數據
print(json.dumps(random_array))  # 直接輸出 JSON 字符串