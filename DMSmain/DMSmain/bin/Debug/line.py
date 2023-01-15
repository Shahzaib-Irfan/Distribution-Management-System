import matplotlib.pyplot as plt

# Styles for the chart
plt.style.use('seaborn-whitegrid')

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

plt.plot(list_one, list_two)
plt.title("Profit Loss Trends")
plt.xlabel("Worth")
plt.ylabel("Performance against Labels")
plt.savefig("Profit-Loss.pdf")
plt.show()
