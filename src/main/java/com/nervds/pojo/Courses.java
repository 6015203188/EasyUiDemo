package com.nervds.pojo;

import com.alibaba.fastjson.annotation.JSONField;

public class Courses {
    private Integer id;

    private String student;

    @JSONField(name = "class")
    private String class_;

    private Integer score;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getStudent() {
        return student;
    }

    public void setStudent(String student) {
        this.student = student == null ? null : student.trim();
    }

    public String getClass_() {
        return class_;
    }

    public void setClass(String class_) {
        this.class_ = class_ == null ? null : class_.trim();
    }

    public Integer getScore() {
        return score;
    }

    public void setScore(Integer score) {
        this.score = score;
    }
}