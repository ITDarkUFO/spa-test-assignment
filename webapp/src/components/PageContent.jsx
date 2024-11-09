﻿import { React, useState, useEffect } from 'react';
import { Layout, Typography, Row, Flex, Button, Modal, Input } from 'antd';

import { useModal } from '../context/ModalContext';

import CreateProductButton from '../components/CreateProductButton';
import CardsList from '../components/CardsList';

import axios from '../api/axios'

const { Title, Paragraph } = Typography;

const PageContent = () => {
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(null);

    const [data, setData] = useState(null);
    const [error, setError] = useState(null);
    const [loading, setLoading] = useState(true);
    const { isCreateModalVisible } = useModal();


    useEffect(() => {
        fetchDataAsync();
    }, [isCreateModalVisible]);

    const fetchDataAsync = async () => {
        try {
            const response = await axios.get(`/api/products`, {
                params: {
                    "page": page,
                    "pageSize": pageSize
                },
            });
            console.debug(response);
            setData(response.data.products);
        }
        catch (error) {
            console.error(error);
            setError(error);
        }
        finally {
            setLoading(false);
        }
    }

    if (error) {
        return (
            <Row justify="center" align="middle" style={{ height: '80vh' }}>
                <Paragraph>Возникла ошибка при загрузке товаров</Paragraph>
                <Paragraph>{error}</Paragraph>
            </Row>
        )
    }

    if (loading) {
        return (
            <Row justify="center" align="middle" style={{ height: '80vh' }}>
                <Paragraph style={{ fontSize: 40 }}>Загрузка товаров...</Paragraph>
            </Row>
        )
    }

    return (
        <>
            <Flex justify="space-between">
                <Title>Список товаров</Title>
                <CreateProductButton />
            </Flex>
            {data.length === 0 && (<p>Товаров нет</p>)}
            {data.length > 0 && <CardsList productsData={data} onDelete={setData} />}
        </>
    )
}

export default PageContent;