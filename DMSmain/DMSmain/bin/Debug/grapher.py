import matplotlib.pyplot as plt

list_one = []
list_two = []

with open("parser.txt",'r') as f:
    lines = f.readlines()
    
    list_one = lines[0]
    list_two = lines[1]
    
    list_one = list_one.split(',')
    list_two = list_two.split(',')
    
    for i in list_two:
        i = int(i)


plt.bar(list_one, list_two)
plt.xticks(rotation = 90)
plt.title('Rider Graphs')
plt.xlabel('Riders')
plt.ylabel('Days')
plt.savefig('Rider.pdf')
plt.show()
