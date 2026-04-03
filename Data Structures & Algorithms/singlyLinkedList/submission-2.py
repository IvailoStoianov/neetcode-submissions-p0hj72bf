from typing import List, Optional

class Node:
    def __init__(self, value: int, next: Optional['Node'] = None):
        self.value = value
        self.next = next


class LinkedList:
    
    def __init__(self):
        self.head: Optional[Node] = None
        self.tail: Optional[Node] = None

    
    def get(self, index: int) -> int:
        crr = self.head
        for _ in range(index):
            if not crr:
                return -1
            crr = crr.next
        
        return crr.value if crr else -1
        

    def insertHead(self, val: int) -> None:
        new_head = Node(val, self.head)
        self.head = new_head
        
        if not self.tail:  
            self.tail = new_head


    def insertTail(self, val: int) -> None:
        new_tail = Node(val)

        if not self.tail:  
            self.head = self.tail = new_tail
            return

        self.tail.next = new_tail
        self.tail = new_tail
        

    def remove(self, index: int) -> bool:
        if not self.head:
            return False

        if index == 0:
            self.head = self.head.next
            if not self.head:
                self.tail = None
            return True

        crr = self.head
        for _ in range(index - 1):
            if not crr.next:
                return False
            crr = crr.next

        if not crr.next:
            return False

        if crr.next == self.tail:
            self.tail = crr

        crr.next = crr.next.next
        return True
        

    def getValues(self) -> List[int]:
        crr = self.head
        val_list = []

        while crr:
            val_list.append(crr.value)
            crr = crr.next  

        return val_list