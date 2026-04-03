class Solution:
    def countStudents(self, students: List[int], sandwiches: List[int]) -> int:
        students_map = {}
        #gen frequency map
        for student in students:
            if student in students_map:
                students_map[student] += 1
            else:
                students_map[student] = 1
        # go though the sandwiches deducting 1 
        # from the students frequency map when we have a match

        for sandwich in sandwiches:
            if sandwich in students_map and students_map[sandwich] > 0:
                students_map[sandwich] -= 1
            else:
                break
        
        # sum the students map to see how many students 
        # are left without a sandwich and return
        students_left = 0
        for student in students_map:
            students_left += students_map[student]
        
        return students_left