package com.nervds.po;


import lombok.Data;

/**
 * 接收前端传过来的参数--课程
 */

@Data
public class CoursePagePO {
    // 当前页面
    private int page;
    // 每页记录数
    private int rows;

    //排序字段
    private String sort;

    //排序类型 asc\desc
    private String order;

    /*Course的属性值*/
    private Integer id;
    private String student;
    private String class_;
    private Integer score;
}
