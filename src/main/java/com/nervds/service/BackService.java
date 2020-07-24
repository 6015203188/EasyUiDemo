package com.nervds.service;

import com.nervds.mapper.CoursesMapper;
import com.nervds.pojo.Courses;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class BackService {

    @Autowired
    private CoursesMapper coursesMapper;

    public List<Courses> getTreeData(String sort,String order) {
        return coursesMapper.selectByExample( sort, order);
    }
}
