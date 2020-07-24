package com.nervds.mapper;

import com.nervds.pojo.Courses;
import org.apache.ibatis.annotations.Mapper;
import org.apache.ibatis.annotations.Param;

import java.util.List;

@Mapper
public interface CoursesMapper {


    List<Courses> selectByExample(@Param("sort") String sort, @Param("order") String order);

}