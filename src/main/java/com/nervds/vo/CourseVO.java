package com.nervds.vo;

import com.nervds.pojo.Courses;
import lombok.Data;

import java.util.List;

@Data
public class CourseVO {

    private List<Courses> rows;
    private long total;
}
