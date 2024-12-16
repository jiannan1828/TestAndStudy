import time

from View.v_ThreadTest import *

def thread1():
    i = 0
    while(True):
        i = i + 1
        time.sleep(1)
        
        

def thread2():
    i = 0
    while(True):
        i = i + 2
        time.sleep(1)
        